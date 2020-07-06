using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;
using CloudFlareUtilities;

namespace tibia_advertise
{
    public partial class Main : Form
    {
        // List of game worlds
        public static List<string> worlds = new List<string>();

        // List of players online
        public static List<Player> players = new List<Player>();

        // Variable to check whether to randomize the list or not
        public static bool randomizePlayers = false;

        public Main()
        {
            InitializeComponent();

            // Populate the list of game worlds
            worldList.Items.AddRange(File.ReadAllLines("settings/worlds.txt"));
            if (worldList.Items.Count > 0) worldList.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void checkTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTop.Checked == true)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void checkRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRandom.Checked == true)
                randomizePlayers = true;
            else
                randomizePlayers = false;
        }

        private async void loadOnlinelist_Click(object sender, EventArgs e)
        {
            // Clear the lists of players
            if (players.Count > 0) players.Clear();
            if (playerList.Items.Count > 0) playerList.Items.Clear();

            // Get the list of players for the selected world
            var table = await onlinePlayers("https://www.tibia.com/community/?subtopic=worlds&world=" + worldList.Text);
            foreach (var row in table)
            {
                // Create a new Player-object
                Player player = new Player();
                player.Name = row[0];
                player.Level = Int32.Parse(row[1]);
                player.Vocation = row[2];
                player.World = worldList.Text;

                // Exclude players that has already been messaged
                if (!File.ReadAllLines("settings/players.txt").Contains(player.Name))
                    players.Add(player);
            }

            // Check if to randomize the players
            if (randomizePlayers == true)
                players = players.OrderBy(a => Guid.NewGuid()).ToList();

            // Populate the list of players
            foreach (Player player in players)
                playerList.Items.Add(player);

            // Print the amount of players
            playerArea.Text = "Players (" + playerList.Items.Count + " Online)";
        }

        /// <summary>
        /// Function that will output a list of players online
        /// on a specific game world. Data taken from www.tibia.com
        /// </summary>
        private static async Task<List<List<string>>> onlinePlayers(string url)
        {
            // Load the url and a CloudFlare cookie
            var baseAddress = new Uri(url);
            var cookieContainer = new CookieContainer();
            cookieContainer.Add(new Cookie("__cfduid", "d87fb33cb80530521fdcb94595a49f14e1580649982", "/", "tibia.com"));

            // Attempt to get the online list
            using (var cfHandler = new ClearanceHandler { MaxRetries = 3 })
            {
                // Make sure the HttpClient is using the CloudFlare cookies
                // and handler, to be able to bypass CloudFlare protection
                cfHandler.InnerHandler = new HttpClientHandler()
                {
                    UseCookies = true,
                    CookieContainer = cookieContainer,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                };

                using (var client = new HttpClient(cfHandler, false) { BaseAddress = baseAddress })
                {
                    // Load the HTML from the page
                    var html = await client.GetStringAsync(baseAddress);
                    var document = new HtmlAgilityPack.HtmlDocument();
                    document.LoadHtml(html);

                    // Find the online list table and extract the list of players
                    var onlineTable = document.DocumentNode.SelectSingleNode("//table[@class='Table2']");
                    return onlineTable.Descendants("tr").Skip(2).Select(tr => tr.Descendants("td").Select(td => WebUtility.HtmlDecode(td.InnerText)).ToList()).ToList();
                }
            }
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerList.SelectedItem != null)
            {
                // Update the details window
                labelDetails.Text = "Name: " + ((Player)playerList.SelectedItem).Name + Environment.NewLine +
                                    "Level: " + ((Player)playerList.SelectedItem).Level + Environment.NewLine +
                                    "Vocation: " + ((Player)playerList.SelectedItem).Vocation + Environment.NewLine +
                                    "World: " + ((Player)playerList.SelectedItem).World;

                // Add the player to the history list
                if (!File.ReadAllLines("settings/players.txt").Contains(((Player)playerList.SelectedItem).Name))
                    File.AppendAllText("settings/players.txt", ((Player)playerList.SelectedItem).Name + Environment.NewLine);

                // URL-friendly character name
                string urlEncoded = ((Player)playerList.SelectedItem).Name.Replace(" ", "+");

                // Variables, for convenience
                Dictionary<string, string> msgVariables = new Dictionary<string, string>();
                msgVariables.Add("{Name}", ((Player)playerList.SelectedItem).Name);
                msgVariables.Add("{Level}", ((Player)playerList.SelectedItem).Level.ToString());
                msgVariables.Add("{Vocation}", ((Player)playerList.SelectedItem).Vocation);
                msgVariables.Add("{World}", ((Player)playerList.SelectedItem).World);
                msgVariables.Add("{Link}", File.ReadLines("settings/link.txt").Skip(1).First());
                msgVariables.Add("{LinkName}", File.ReadLines("settings/link.txt").Skip(1).First() + urlEncoded);

                // Load the message
                string message = File.ReadLines("settings/message.txt").Skip(9).First();

                // Convert variables to values
                foreach (var wordToReplace in msgVariables)
                    message = message.Replace(wordToReplace.Key, wordToReplace.Value);

                // Copy the text to clipboard
                Clipboard.SetText(message);

                // Remove the player from the list
                playerList.Items.Remove(playerList.SelectedItem);
            }
        }

        private void signBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.signBox, "Tibia Advertisement Tool - Build v1.0" + Environment.NewLine + "Created by Bay Antica [07/06/2020]");
        }
    }
}

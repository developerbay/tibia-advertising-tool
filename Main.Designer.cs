namespace tibia_advertise
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.settingsArea = new System.Windows.Forms.GroupBox();
            this.checkRandom = new System.Windows.Forms.CheckBox();
            this.checkTop = new System.Windows.Forms.CheckBox();
            this.loadOnlinelist = new System.Windows.Forms.Button();
            this.worldList = new System.Windows.Forms.ComboBox();
            this.playerArea = new System.Windows.Forms.GroupBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.detailsArea = new System.Windows.Forms.GroupBox();
            this.signBox = new System.Windows.Forms.PictureBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.settingsArea.SuspendLayout();
            this.playerArea.SuspendLayout();
            this.detailsArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signBox)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsArea
            // 
            this.settingsArea.Controls.Add(this.checkRandom);
            this.settingsArea.Controls.Add(this.checkTop);
            this.settingsArea.Controls.Add(this.loadOnlinelist);
            this.settingsArea.Controls.Add(this.worldList);
            this.settingsArea.Location = new System.Drawing.Point(13, 12);
            this.settingsArea.Name = "settingsArea";
            this.settingsArea.Size = new System.Drawing.Size(307, 77);
            this.settingsArea.TabIndex = 0;
            this.settingsArea.TabStop = false;
            this.settingsArea.Text = "Settings";
            // 
            // checkRandom
            // 
            this.checkRandom.AutoSize = true;
            this.checkRandom.Location = new System.Drawing.Point(116, 51);
            this.checkRandom.Name = "checkRandom";
            this.checkRandom.Size = new System.Drawing.Size(79, 17);
            this.checkRandom.TabIndex = 3;
            this.checkRandom.Text = "Randomize";
            this.checkRandom.UseVisualStyleBackColor = true;
            this.checkRandom.CheckedChanged += new System.EventHandler(this.checkRandom_CheckedChanged);
            // 
            // checkTop
            // 
            this.checkTop.AutoSize = true;
            this.checkTop.Location = new System.Drawing.Point(12, 51);
            this.checkTop.Name = "checkTop";
            this.checkTop.Size = new System.Drawing.Size(98, 17);
            this.checkTop.TabIndex = 2;
            this.checkTop.Text = "Window on top";
            this.checkTop.UseVisualStyleBackColor = true;
            this.checkTop.CheckedChanged += new System.EventHandler(this.checkTop_CheckedChanged);
            // 
            // loadOnlinelist
            // 
            this.loadOnlinelist.Location = new System.Drawing.Point(206, 18);
            this.loadOnlinelist.Name = "loadOnlinelist";
            this.loadOnlinelist.Size = new System.Drawing.Size(90, 28);
            this.loadOnlinelist.TabIndex = 1;
            this.loadOnlinelist.Text = "Load";
            this.loadOnlinelist.UseVisualStyleBackColor = true;
            this.loadOnlinelist.Click += new System.EventHandler(this.loadOnlinelist_Click);
            // 
            // worldList
            // 
            this.worldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worldList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldList.FormattingEnabled = true;
            this.worldList.Location = new System.Drawing.Point(12, 19);
            this.worldList.Name = "worldList";
            this.worldList.Size = new System.Drawing.Size(186, 26);
            this.worldList.TabIndex = 0;
            // 
            // playerArea
            // 
            this.playerArea.Controls.Add(this.playerList);
            this.playerArea.Location = new System.Drawing.Point(13, 95);
            this.playerArea.Name = "playerArea";
            this.playerArea.Size = new System.Drawing.Size(307, 165);
            this.playerArea.TabIndex = 1;
            this.playerArea.TabStop = false;
            this.playerArea.Text = "Players";
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 18;
            this.playerList.Location = new System.Drawing.Point(12, 20);
            this.playerList.Name = "playerList";
            this.playerList.ScrollAlwaysVisible = true;
            this.playerList.Size = new System.Drawing.Size(284, 130);
            this.playerList.TabIndex = 0;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // detailsArea
            // 
            this.detailsArea.Controls.Add(this.signBox);
            this.detailsArea.Controls.Add(this.labelDetails);
            this.detailsArea.Location = new System.Drawing.Point(13, 267);
            this.detailsArea.Name = "detailsArea";
            this.detailsArea.Size = new System.Drawing.Size(307, 88);
            this.detailsArea.TabIndex = 2;
            this.detailsArea.TabStop = false;
            this.detailsArea.Text = "Details";
            // 
            // signBox
            // 
            this.signBox.Image = ((System.Drawing.Image)(resources.GetObject("signBox.Image")));
            this.signBox.Location = new System.Drawing.Point(245, 20);
            this.signBox.Name = "signBox";
            this.signBox.Size = new System.Drawing.Size(56, 59);
            this.signBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.signBox.TabIndex = 1;
            this.signBox.TabStop = false;
            this.signBox.MouseHover += new System.EventHandler(this.signBox_MouseHover);
            // 
            // labelDetails
            // 
            this.labelDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(12, 20);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(226, 59);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "Name: \r\nLevel: \r\nVocation: \r\nWorld: ";
            // 
            // labelCredits
            // 
            this.labelCredits.Location = new System.Drawing.Point(13, 358);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(307, 16);
            this.labelCredits.TabIndex = 3;
            this.labelCredits.Text = "Created by Bay Antica, 2020";
            this.labelCredits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 377);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.detailsArea);
            this.Controls.Add(this.playerArea);
            this.Controls.Add(this.settingsArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Tibia Advertisement Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.settingsArea.ResumeLayout(false);
            this.settingsArea.PerformLayout();
            this.playerArea.ResumeLayout(false);
            this.detailsArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsArea;
        private System.Windows.Forms.Button loadOnlinelist;
        private System.Windows.Forms.ComboBox worldList;
        private System.Windows.Forms.CheckBox checkRandom;
        private System.Windows.Forms.CheckBox checkTop;
        private System.Windows.Forms.GroupBox playerArea;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.GroupBox detailsArea;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.PictureBox signBox;
        private System.Windows.Forms.Label labelCredits;
    }
}


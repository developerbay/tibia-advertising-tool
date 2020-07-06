using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibia_advertise
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Vocation { get; set; }
        public string World { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}

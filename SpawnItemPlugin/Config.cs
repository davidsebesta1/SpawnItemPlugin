using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnItemPlugin.Plugin
{
    internal class Config
    {
        [Description("Is plugin enabled")]
        public bool isEnabled = true; // enabled by default

        [Description("Class ID with random item on spawn")]
        public int id = 1; // 1 default, d class

        [Description("Item ID to spawn")]
        public byte itemID = 0; // 0 default, janitor keycard
    }
}

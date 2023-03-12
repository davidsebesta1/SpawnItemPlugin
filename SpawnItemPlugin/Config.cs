using PlayerRoles;
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
        public readonly bool isEnabled = true; // enabled by default

        [Description("Class ID with random item on spawn")]
        public readonly RoleTypeId roleID = RoleTypeId.ClassD; // role type, d class by default

        [Description("Item ID to spawn")]
        public readonly ItemType item = ItemType.KeycardJanitor; // item to randomly spawn with, janitor keycard by default

        [Description("Random number to generate")]
        public readonly int randomNumberTop = 5; // number to generate in random generator, 5 by default

        [Description("Random number requirement")]
        public readonly int randomNumberRequirement = 3; // number (!lower than generateNumberTop!) required to give the player starting item
    }
}

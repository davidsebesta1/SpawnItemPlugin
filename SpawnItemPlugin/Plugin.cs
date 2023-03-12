using InventorySystem;
using PlayerRoles;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

using System;


namespace SpawnItemPlugin.Plugin
{
    internal class Plugin
    {
        //Variables
        private Random random = new Random();

        //Configuration variable
        [PluginConfig]
        public Config configuration;

        //Plugin entry point
        [PluginEntryPoint("RandomSpawnItems", "1.0.0", "spawn with random item as d class", "davidsebesta")]
        void Enabled() {
            EventManager.RegisterEvents((object)this);
            Log.Info("RandomSpawnItem enabled");
        }

        //On spawn random item
        [PluginEvent(ServerEventType.PlayerSpawn)]
        void OnPlayerSpawned(Player player, RoleTypeId role)
        {
            if(role == configuration.roleID) // required role
            {
                if(random.Next(configuration.randomNumberTop) >= configuration.randomNumberRequirement) // randomization
                {
                    player.ReferenceHub.inventory.ServerAddItem(configuration.item);
                    Log.Info("Player: " + player.Nickname + " has randomly spawned with " + configuration.item.ToString());
                }
            }
        }
    }
}

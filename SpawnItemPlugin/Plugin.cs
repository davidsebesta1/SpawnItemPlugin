using InventorySystem;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.Firearms.Attachments;
using PlayerRoles;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

using System;
using System.Reflection;
using System.Threading;
using UnityEngine;

using MEC;


namespace SpawnItemPlugin.Plugin
{
    internal class Plugin
    {
        //Variables
        private System.Random random = new System.Random();

        //Configuration variable
        [PluginConfig]
        public Config configuration;

        //Plugin entry point
        [PluginEntryPoint("RandomSpawnItems", "1.0.0", "spawn with random item as d class", "davidsebesta")]
        void Enabled() {
            EventManager.RegisterEvents((object)this);

            string textEnabledVar = configuration.isEnabled ? "enabled" : "disabled";
            Log.Info("RandomSpawnItem " + textEnabledVar);
        }

        //On spawn random item
        [PluginEvent(ServerEventType.PlayerSpawn)]
        void OnPlayerSpawned(Player player, RoleTypeId role)
        {
            if (configuration.isEnabled){ // is plugin enabled check
                if (role == configuration.roleID && player != null) // required role
                {
                    if (random.Next(configuration.randomNumberTop) >= configuration.randomNumberRequirement) // randomization
                    {
                        Timing.CallDelayed(1f, (Action)(() => { // delay cause otherwise it doesnt work
                            player.ReferenceHub.inventory.ServerAddItem(ItemType.KeycardJanitor);
                            Log.Info("Player " + player.Nickname + " has randomly spawned with " + configuration.item.ToString());
                        }));
                    }
                } else
                {
                    Log.Info("Player didnt spawn with a keycard");
                }
            }
        }
    }
}

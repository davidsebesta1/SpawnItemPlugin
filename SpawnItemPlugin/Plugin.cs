using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace SpawnItemPlugin.Plugin
{

    internal class Plugin
    {
        [PluginConfig]
        public Config configuration;

        [PluginEntryPoint("RandomSpawnItems", "1.0.0", "spawn with random item as d class", "davidsebesta")]
        void Enabled() {
            EventManager.RegisterEvents((object)this);
        }

        [PluginEvent(ServerEventType.PlayerSpawn)]
        void OnPlayerSpawned(Player player, RoleTypeID roleID)
        {

        }
    }
}

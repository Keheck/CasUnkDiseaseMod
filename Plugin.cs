using BepInEx;
using BepInEx.Logging;
using CUCoreLib.ContentReload;
using CUCoreLib.Registries;

namespace KeheckDisease
{
    [BepInPlugin(MOD_GUID, MOD_NAME, MOD_VERSION)]
    [BepInDependency("net.cucorelib")]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        public const string MOD_GUID = "io.github.keheck.casudisease";
        public const string MOD_NAME = "Quarantine Protocol";
        public const string MOD_VERSION = "1.0.0";

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {MOD_GUID} is loaded!");
            ConsoleCommandRegistry.Register(new Command())
            ContentReloadManager.EnableHotReload(MOD_GUID);
            RegisterReplayable();
        }

        private void RegisterReplayable()
        {

        }
    }
}

using BepInEx;

namespace RiskOfRigatoni2
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class RiskOfRigatoni2 : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "Jeffdev";
        public const string PluginName = "RiskOfRigatoni2";
        public const string PluginVersion = "1.0.0";
        public static RiskOfRigatoni2 instance;

        public void Awake()
        {
            Log.Init(Logger);
            instance = this;
        }
    }
}

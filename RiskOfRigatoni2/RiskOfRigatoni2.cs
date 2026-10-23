using BepInEx;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityHotReloadNS;

namespace RiskOfRigatoni2
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency("iDeathHD.UnityHotReload", BepInDependency.DependencyFlags.SoftDependency)]
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
        #if DEBUG
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.F3))
            {
                DirectorCardCategorySelection dccs = Addressables.LoadAssetAsync<DirectorCardCategorySelection>(key: "RoR2/DLC2/lakesnight/dccsLakesnightMonsters.asset").WaitForCompletion();
            }
            if (Input.GetKeyUp(KeyCode.F1))
            {
                UnityHotReload.LoadNewAssemblyVersion(typeof(RiskOfRigatoni2).Assembly, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Info.Location), "RiskOfRigatoni2.dll"));
            }
        }
        #endif
    }
}

using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace PlateupNuke {

    [BepInProcess("PlateUp.exe")]
    [BepInPlugin(MOD_ID, MOD_NAME, "0.1.1")]
    public partial class Mod : BaseUnityPlugin {

        public const string MOD_ID = "plateupnuke";
        public const string MOD_NAME = "Plateup Nuke";

        public void Awake() {
            initHarmony();
        }

        private void initHarmony() {
            Logger.LogInfo("initHarmony()");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MOD_ID);
        }
    }
}

using BepInEx;
using HarmonyLib;
using KitchenLib.Event;
using System.Reflection;

namespace PlateupNuke {

    [BepInProcess("PlateUp.exe")]
    [BepInPlugin(MOD_ID, MOD_NAME, "0.1.0")]
    public partial class Mod : KitchenLib.BaseMod {

        public const string MOD_ID = "plateupnuke";
        public const string MOD_NAME = "Plateup Nuke";

        public Mod() : base(">=1.1.0", Assembly.GetCallingAssembly()) { }

        public void Start() {
            initHarmony();
        }

        private void initHarmony() {
            Log("initHarmony()");
            Events.StartMainMenu_SetupEvent += (s, args) => {
                Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MOD_ID);
                Log("StartMainMenu_SetupEvent()");
            };
        }
    }
}

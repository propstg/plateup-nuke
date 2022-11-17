using HarmonyLib;
using Kitchen;
using UnityEngine;

namespace PlateupNuke {

    [HarmonyPatch(typeof(MakePing), "Perform")]
    class MakePing_Patch {

        public static bool Prefix(ref Color ___Colour) {

            ___Colour = new Color(175f, 175f, 115f, 0.9f);

            return true;
        }
    }
}

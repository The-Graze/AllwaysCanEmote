using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine.InputSystem;

namespace AllwaysCanEmote.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    [HarmonyPatch("CheckConditionsForEmote")]
    internal class DancePatch
    {
        static bool Prefix(ref bool __result, PlayerControllerB __instance)
        {
            __result = true;
            if (__instance.performingEmote)
            {
                if (__instance.timeSinceStartingEmote > Plugin.DanceTime.Value)
                {
                    __result = false;
                }
            }
            return false;
        }
    }
}
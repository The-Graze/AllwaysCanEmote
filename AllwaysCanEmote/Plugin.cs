using BepInEx;
using BepInEx.Configuration;
using System;
using UnityEngine;
namespace AllwaysCanEmote
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<float> DanceTime;
        Plugin() => BEgin();

        void BEgin()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            DanceTime = Config.Bind("Settings", "Dance Time", 10f, "How Long Untill the emote ends");

        }
    }
}

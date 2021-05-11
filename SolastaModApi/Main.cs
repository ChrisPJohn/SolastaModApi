using HarmonyLib;
using SolastaModApi.Testing;
using System;
using System.Diagnostics;
using UnityModManagerNet;

namespace SolastaModApi
{
    public static class Main
    {
        [Conditional("DEBUG")]
        internal static void Log(string msg) => Logger.Log(msg);

        internal static void Error(Exception ex) => Logger?.Error(ex.ToString());
        internal static void Error(string msg) => Logger?.Error(msg);
        internal static UnityModManager.ModEntry.ModLogger Logger { get; private set; }

        internal static bool Load(UnityModManager.ModEntry modEntry)
        {
            try
            {
                Logger = modEntry.Logger;
#if DEBUG
                modEntry.OnGUI = Tests.OnGUI;

                var harmony = new Harmony(modEntry.Info.Id);
                harmony.PatchAll();
#endif
            }
            catch (Exception ex)
            {
                Error(ex);
                throw;
            }

            return true;
        }
    }
}

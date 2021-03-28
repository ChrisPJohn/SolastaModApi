using System;
using UnityModManagerNet;

namespace SolastaModApi
{
    public class Main
    {
        public static Guid ModGuidNamespace = new Guid("Generate a GUID for your mod and set it here");

        static UnityModManager.ModEntry ModEntry;
        public static void Log(string msg)
        {
            ModEntry?.Logger.Log(msg);
        }
        public static void Error(Exception ex)
        {
            ModEntry?.Logger.Error(ex.ToString());
        }
        public static void Error(string msg)
        {
            ModEntry?.Logger.Error(msg);
        }
        static void Load(UnityModManager.ModEntry modEntry)
        {
            ModEntry = modEntry;
            modEntry.OnUpdate = OnUpdate;
        }

        private static bool initialized = false;
        private static int lastcount = 0;

        static void OnUpdate(UnityModManager.ModEntry modEntry, float time)
        {
            if (!initialized)
            {
                if (DatabaseRepository.DatabasesCount() >= 20 && DatabaseRepository.DatabasesCount() == lastcount)
                {
                    initialized = true;
                    ModifyDatabase();
                }
                if (DatabaseRepository.DatabasesCount() > lastcount)
                {
                    lastcount = DatabaseRepository.DatabasesCount();
                }
            }
        }

        private static void ModifyDatabase()
        {
            // Your code here to modify the databse.
        }
    }
}

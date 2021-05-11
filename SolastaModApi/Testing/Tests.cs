using HarmonyLib;
using SolastaModApi.Diagnostics;
using System;
using System.Linq;
using System.Reflection;
using TA.AI;
using UnityEngine;
using UnityModManagerNet;

namespace SolastaModApi.Testing
{
#if DEBUG
    public static class Tests
    {
        internal static bool DatabaseReady { get; set; }

        internal static void OnGUI(UnityModManager.ModEntry _)
        {
            if (GUILayout.Button("Basic test"))
            {
                Test();
            }

            if (GUILayout.Button("Check database definitions"))
            {
                CheckDatabaseDefinitions();
            }

            if (GUILayout.Button("Check extensions"))
            {
                CheckExtensions();
            }
        }

        private static void Test()
        {
            // Test Repository.Get works as expected and confirm that definitions are stored in multiple 'databases'.
            using (var logger = new MethodLogger(nameof(Main)))
            {
                if (!DatabaseReady)
                {
                    logger.Log("Database not ready.");
                    return;
                }

                try
                {
                    // Get action surge
                    var actionSurge = DatabaseHelper.ActionDefinitions.ActionSurge;
                    logger.Log($"AS1: {actionSurge.GetType().FullName}");

                    // Does Repository get the same thing?
                    var actionSurge2 = Repository.Get<ActionDefinition>("ActionSurge", "eb25cf66be5d2a041a0c079be4a2befc");
                    logger.Log($"AS2: {actionSurge2.GetType().FullName}");

                    logger.Log($"AS1=AS2={ReferenceEquals(actionSurge, actionSurge2)}");

                    // Get the belt of dwarvenkind in various ways
                    const string affinityName = "AbilityCheckAffinityBeltOfDwarvenkind";
                    const string affinityGuid = "54af4a8560ae55444a52f5aea3370b48";

                    var a1 = Repository.Get<FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuid);
                    var a2 = Repository.Get<FeatureDefinitionAffinity>(affinityName, affinityGuid);
                    var a3 = Repository.Get<FeatureDefinition>(affinityName, affinityGuid);

                    logger.Log($"A1=A2={ReferenceEquals(a1, a2)}, A2=A3={ReferenceEquals(a2, a3)}");
                    logger.Log($"A1-type={a1.GetType().FullName}");

                    var a4 = Repository.Get<FeatureDefinitionAbilityCheckAffinity, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuid);
                    var a5 = Repository.Get<FeatureDefinitionAffinity, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuid);
                    var a6 = Repository.Get<FeatureDefinition, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuid);

                    logger.Log($"A4=A5={ReferenceEquals(a4, a5)}, A5=A6={ReferenceEquals(a5, a6)}");
                    logger.Log($"A4-type={a4.GetType().FullName}");

                    // TODO: test adding our own definition and retrieving it.
                    // Ideally need to test RecordTableDefinition, FeatureDefinition, BaseBlueprint, EditableGraphDefinition
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private static void CheckDatabaseDefinitions()
        {
            using (var logger = new MethodLogger(nameof(Main)))
            {
                if (!DatabaseReady)
                {
                    logger.Log("Database not ready.");
                    return;
                }

                try
                {
                    // TODO: enumerate all classes and all properties and get the definition
                    // check it's not null and doesn't throw an exception
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private static void CheckExtensions()
        {
            using (var logger = new MethodLogger(nameof(Main)))
            {
                if (!DatabaseReady)
                {
                    logger.Log("Database not ready.");
                    return;
                }

                try
                {
                    var modAssembly = Assembly.GetExecutingAssembly();

                    // This may not work for all referenced types
                    var solastaAssembly = Assembly.GetAssembly(typeof(ActionDefinition));
                    var solastaAiAssembly = Assembly.GetAssembly(typeof(DecisionDefinition));

                    var types = modAssembly
                        .GetTypes()
                        .Where(t => t.Namespace == "SolastaModApi.Extensions")
                        .Where(t => t.Name.EndsWith("Extensions"))
                        .Select(t => (typeName: t.Name.Remove(t.Name.Length - 10), extensionName: t.FullName))
                        .ToList();

                    foreach (var t in types)
                    {
                        try
                        {
                            var instance = solastaAssembly.CreateInstance(t.typeName);

                            if (instance == null)
                            {
                                instance = solastaAiAssembly.CreateInstance(t.typeName);

                                if (instance == null)
                                    logger.Log($"Unable to create {t.typeName}");
                                else
                                {
                                    // TODO: enumerate all set methods on extension class and call them.
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // types without default constructor can't be created and cause exception
                            logger.Log($"{t.typeName}: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }
    }

    [HarmonyPatch(typeof(MainMenuScreen), "RuntimeLoaded")]
    internal static class MainMenuScreen_RuntimeLoaded_Patch
    {
        internal static void Postfix()
        {
            Tests.DatabaseReady = true;
        }
    }
#endif
}

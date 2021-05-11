using HarmonyLib;
using SolastaModApi.Diagnostics;
using SolastaModApi.Infrastructure;
using System;
using System.Linq;
using System.Reflection;
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
                    logger.Log("Database definition tests: TODO.");

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
                    var extensions = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace == "SolastaModApi.Extensions")
                        .Where(t => t.Name.EndsWith("Extensions"))
                        .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(TargetTypeAttribute)))
                        .Select(t => new
                        {
                            Type = t,
                            t.GetCustomAttributes<TargetTypeAttribute>().First().TargetType
                        })
                        .ToList();

                    int totalMethodsCalled = 0;

                    foreach (var extension in extensions)
                    {
                        try
                        {
                            var ctor = extension.TargetType.GetConstructor(Array.Empty<Type>());

                            if (ctor == null)
                            {
                                logger.Log($"WARN: skipping type {extension.TargetType.Name}.  No default constructor.");
                                // TODO: create instances of types required for none default constructors, is it worth it?
                            }
                            else if (extension.TargetType.IsAbstract)
                            {
                                logger.Log($"WARN: skipping type {extension.TargetType.Name}. Abstract type.");
                                // TODO: find and create descendant concrete type for use in tests
                            }
                            else
                            {
                                var instance = extension.TargetType.IsSubclassOf(typeof(ScriptableObject))
                                    ? ScriptableObject.CreateInstance(extension.TargetType.FullName)
                                    : ctor.Invoke(Array.Empty<object>());

                                if (instance == null)
                                {
                                    logger.Log($"ERROR: unable to create {extension.TargetType.Name} - Unknown reason.");
                                }
                                else
                                {
                                    var setters = extension.Type
                                        .GetMethods(BindingFlags.Static | BindingFlags.Public)
                                        .Where(m => m.Name.StartsWith("Set"));

                                    int methodsCalled = 0;

                                    foreach (var setter in setters)
                                    {
                                        try
                                        {
                                            var parms = setter.GetParameters();

                                            if (parms.Length == 2)
                                            {
                                                if (setter.IsGenericMethod)
                                                {
                                                    setter
                                                        .MakeGenericMethod(extension.TargetType)
                                                        .Invoke(null, new object[] { instance, GetDefaultValue() });
                                                }
                                                else
                                                {
                                                    // sealed type extensions aren't generic
                                                    setter
                                                        .Invoke(null, new object[] { instance, GetDefaultValue() });
                                                }

                                                methodsCalled++;

                                                object GetDefaultValue()
                                                {
                                                    var valueParm = parms[1];

                                                    return valueParm.ParameterType.IsValueType
                                                        ? Activator.CreateInstance(valueParm.ParameterType)
                                                        : null;
                                                }
                                            }
                                            else
                                            {
                                                logger.Log($"Skipping method '{extension.TargetType.Name}.{setter.Name}', doesn't have 2 params.");
                                            }
                                        }
                                        catch(Exception ex1)
                                        {
                                            logger.Log($"Error calling method '{extension.TargetType.Name}.{setter.Name}': {ex1.Message}.");
                                        }
                                    }

                                    //logger.Log($"'{extension.TargetType.Name}' - successfully called {methodsCalled} extension methods.");

                                    totalMethodsCalled += methodsCalled;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Log($"ERROR: testing '{extension.TargetType.Name}': {ex.Message}");
                        }

                    }

                    logger.Log("");
                    logger.Log($"'Successfully called grand total of '{totalMethodsCalled}' extension methods.");
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

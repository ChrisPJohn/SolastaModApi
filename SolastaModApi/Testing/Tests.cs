using HarmonyLib;
using SolastaModApi.Diagnostics;
using SolastaModApi.Infrastructure;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityModManagerNet;
using ModKit;

namespace SolastaModApi.Testing
{
#if DEBUG
    public static class Tests
    {
        internal static bool DatabaseReady { get; set; }

        internal static void OnGUI(UnityModManager.ModEntry _)
        {
            UI.HStack("Tests", 4,
                () => { UI.ActionButton("Basic Tests", () => { BasicTests(); }); },
                () => { UI.ActionButton("Database Definitions", () => { CheckDatabaseDefinitions(); }); },
                () => { UI.ActionButton("Database Definitions 2", () => { CheckDatabaseDefinitions2(); }); },
                () => { UI.ActionButton("Extensions", () => { CheckExtensions(); }); }
            );
        }

        private static void BasicTests()
        {
            // Test Repository.Get works as expected and confirm that definitions are stored in multiple 'databases'.
            using (var logger = new MethodLogger(nameof(Tests)))
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
                    const string affinityGuidString = "54af4a8560ae55444a52f5aea3370b48";

                    var a1 = Repository.GetByName<FeatureDefinitionAbilityCheckAffinity>(affinityName);
                    var a2 = Repository.GetByName<FeatureDefinitionAffinity>(affinityName);
                    var a3 = Repository.GetByName<FeatureDefinition>(affinityName);

                    var a11 = Repository.GetByGuid<FeatureDefinitionAbilityCheckAffinity>(affinityGuidString);
                    var a21 = Repository.GetByGuid<FeatureDefinitionAffinity>(affinityGuidString);
                    var a31 = Repository.GetByGuid<FeatureDefinition>(affinityGuidString);

                    logger.Log($"A1=A2={ReferenceEquals(a1, a2)}, A2=A3={ReferenceEquals(a2, a3)}");
                    logger.Log($"A1=A11={ReferenceEquals(a1, a11)}, A21=A31={ReferenceEquals(a21, a31)}");
                    logger.Log($"A1-type={a1.GetType().FullName}");

                    var a4 = Repository.Get<FeatureDefinitionAbilityCheckAffinity, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuidString);
                    var a5 = Repository.Get<FeatureDefinitionAffinity, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuidString);
                    var a6 = Repository.Get<FeatureDefinition, FeatureDefinitionAbilityCheckAffinity>(affinityName, affinityGuidString);

                    logger.Log($"A4=A5={ReferenceEquals(a4, a5)}, A5=A6={ReferenceEquals(a5, a6)}");
                    logger.Log($"A4-type={a4.GetType().FullName}");

                    // Test adding our own definition and retrieving it.
                    var testDefinitionGuid = "62565155-4d2e-4d72-a651-f8b0749f22a1";
                    const string testDefinitionName = "test";

                    CharacterSubclassDefinition c1 = Repository.GetByGuid<CharacterSubclassDefinition>(testDefinitionGuid);

                    if (c1 == null)
                    {
                        var builder = new CharacterSubclassDefinitionBuilder(testDefinitionName, testDefinitionGuid);
                        c1 = builder.AddToDB();
                    }

                    logger.Log($"C1 created={c1 != null}");

                    var c2 = Repository.GetByName<CharacterSubclassDefinition>(testDefinitionName);
                    var c3 = Repository.GetByGuid<CharacterSubclassDefinition>(testDefinitionGuid);
                    logger.Log($"C1=C2={ReferenceEquals(c1, c2)}, C1=C3={ReferenceEquals(c1, c3)}");
                    
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
            using (var logger = new MethodLogger(nameof(Tests)))
            {
                if (!DatabaseReady)
                {
                    logger.Log("Database not ready.");
                    return;
                }

                try
                {
                    var dbHelperTypes = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace == "SolastaModApi").ToList()
                        .Where(t => t.FullName.StartsWith("SolastaModApi.DatabaseHelper"))
                        .Where(t => t.MemberType == MemberTypes.NestedType)
                        .OrderBy(t => t.Name);

                    int totalGettersSucceeded = 0;

                    foreach (var dbHelperType in dbHelperTypes)
                    {
                        var propertyGetters = dbHelperType
                            .GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty);

                        int gettersSucceeded = 0;

                        foreach (var getter in propertyGetters)
                        {
                            try
                            {
                                var result = getter.GetMethod.Invoke(null, Array.Empty<object>());

                                if(result == null)
                                {
                                    logger.Log($"ERROR property '{dbHelperType.Name}.{getter.Name}' returned NULL.");
                                }
                                else
                                {
                                    gettersSucceeded++;
                                }
                               
                            }
                            catch(Exception ex)
                            {
                                logger.Log($"ERROR getting property '{dbHelperType.Name}.{getter.Name}': {ex.Message}.");
                            }
                        }

                        totalGettersSucceeded += gettersSucceeded;
                    }

                    logger.Log($"Successfully invoked grand total of {totalGettersSucceeded} db helper properties.");
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private static void CheckDatabaseDefinitions2()
        {
            using (var logger = new MethodLogger(nameof(Tests)))
            {
                if (!DatabaseReady)
                {
                    logger.Log("Database not ready.");
                    return;
                }

                try
                {
                    var dbHelperTypes = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => t.Namespace == "SolastaModApi.DatabaseHelpers").ToList()
                        .Where(t => t.Name.EndsWith("Set"))
                        .OrderBy(t => t.Name);

                    int totalGettersSucceeded = 0;

                    foreach (var dbHelperType in dbHelperTypes)
                    {
                        var propertyGetters = dbHelperType
                            .GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty);

                        int gettersSucceeded = 0;

                        foreach (var getter in propertyGetters)
                        {
                            try
                            {
                                var result = getter.GetMethod.Invoke(null, Array.Empty<object>());

                                if(result == null)
                                {
                                    logger.Log($"ERROR property '{dbHelperType.Name}.{getter.Name}' returned NULL.");
                                }
                                else
                                {
                                    gettersSucceeded++;
                                }
                               
                            }
                            catch(Exception ex)
                            {
                                logger.Log($"ERROR getting property '{dbHelperType.Name}.{getter.Name}': {ex.Message}.");
                            }
                        }

                        totalGettersSucceeded += gettersSucceeded;
                    }

                    logger.Log($"Successfully invoked grand total of {totalGettersSucceeded} db helper properties.");
                }
                catch (Exception ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private static void CheckExtensions()
        {
            using (var logger = new MethodLogger(nameof(Tests)))
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
                        .OrderBy(t => t.Type.Name)
                        .ToList();

                    int totalMethodsSucceeded = 0;

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

                                    int methodsSucceeded = 0;

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

                                                methodsSucceeded++;

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

                                    // Removed this because it too chatty.
                                    //logger.Log($"'{extension.TargetType.Name}' - successfully called {methodsCalled} extension methods.");

                                    totalMethodsSucceeded += methodsSucceeded;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Log($"ERROR: testing '{extension.TargetType.Name}': {ex.Message}");
                        }

                    }

                    logger.Log("---------------------------");
                    logger.Log($"Successfully called grand total of {totalMethodsSucceeded} extension setter methods.");
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

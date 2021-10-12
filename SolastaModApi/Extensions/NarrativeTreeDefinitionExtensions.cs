using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(NarrativeTreeDefinition))]
    public static partial class NarrativeTreeDefinitionExtensions
    {
        public static T SetAvailableCameraShotNames<T>(this T entity, string[] value)
            where T : NarrativeTreeDefinition
        {
            entity.AvailableCameraShotNames = value;
            return entity;
        }

        public static T SetAvailableCameraTargetNames<T>(this T entity, string[] value)
            where T : NarrativeTreeDefinition
        {
            entity.AvailableCameraTargetNames = value;
            return entity;
        }

        public static T SetGeneratedCameraShotNames<T>(this T entity, string[] value)
            where T : NarrativeTreeDefinition
        {
            entity.GeneratedCameraShotNames = value;
            return entity;
        }

        public static T SetHasSpecialCutsceneLightingForCharacters<T>(this T entity, bool value)
            where T : NarrativeTreeDefinition
        {
            entity.HasSpecialCutsceneLightingForCharacters = value;
            return entity;
        }

        public static T SetNarrativeCameraSetupGUID<T>(this T entity, string value)
            where T : NarrativeTreeDefinition
        {
            entity.NarrativeCameraSetupGUID = value;
            return entity;
        }

        public static T SetSerializeVersion<T>(this T entity, int value)
            where T : NarrativeTreeDefinition
        {
            entity.SerializeVersion = value;
            return entity;
        }

        public static T SetSkippable<T>(this T entity, bool value)
            where T : NarrativeTreeDefinition
        {
            entity.Skippable = value;
            return entity;
        }

        public static T SetUnequipWieldedItems<T>(this T entity, bool value)
            where T : NarrativeTreeDefinition
        {
            entity.UnequipWieldedItems = value;
            return entity;
        }
    }
}
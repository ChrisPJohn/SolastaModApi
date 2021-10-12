using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionSavingThrowAffinity))]
    public static partial class FeatureDefinitionSavingThrowAffinityExtensions
    {
        public static T SetIndomitableSavingThrows<T>(this T entity, int value)
            where T : FeatureDefinitionSavingThrowAffinity
        {
            entity.SetField("indomitableSavingThrows", value);
            return entity;
        }

        public static T SetPriorityAbilityScore<T>(this T entity, string value)
            where T : FeatureDefinitionSavingThrowAffinity
        {
            entity.SetField("priorityAbilityScore", value);
            return entity;
        }

        public static T SetUseControllerSavingThrows<T>(this T entity, bool value)
            where T : FeatureDefinitionSavingThrowAffinity
        {
            entity.SetField("useControllerSavingThrows", value);
            return entity;
        }
    }
}
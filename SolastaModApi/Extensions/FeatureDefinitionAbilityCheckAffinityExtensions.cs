using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAbilityCheckAffinity))]
    public static partial class FeatureDefinitionAbilityCheckAffinityExtensions
    {
        public static T SetUseControllerAbilityChecks<T>(this T entity, bool value)
            where T : FeatureDefinitionAbilityCheckAffinity
        {
            entity.SetField("useControllerAbilityChecks", value);
            return entity;
        }
    }
}
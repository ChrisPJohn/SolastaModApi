using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionMoveThroughEnemyModifier))]
    public static class FeatureDefinitionMoveThroughEnemyModifierExtensions
    {
        public static T SetMinSizeDifference<T>(this T entity, int value)
            where T : FeatureDefinitionMoveThroughEnemyModifier
        {
            entity.SetField("minSizeDifference", value);
            return entity;
        }
    }
}
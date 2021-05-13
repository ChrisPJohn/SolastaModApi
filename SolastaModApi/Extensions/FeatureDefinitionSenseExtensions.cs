using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionSense))]
    public static class FeatureDefinitionSenseExtensions
    {
        public static T SetSenseRange<T>(this T entity, int value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("senseRange", value);
            return entity;
        }

        public static T SetSenseType<T>(this T entity, SenseMode.Type value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("senseType", value);
            return entity;
        }

        public static T SetStealthBreakerRange<T>(this T entity, int value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("stealthBreakerRange", value);
            return entity;
        }
    }
}
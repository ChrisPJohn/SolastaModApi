using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionLanguageAffinity))]
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static T SetUniversalReader<T>(this T entity, bool value)
            where T : FeatureDefinitionLanguageAffinity
        {
            entity.SetField("universalReader", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionFeatureSet))]
    public static class FeatureDefinitionFeatureSetExtensions
    {
        public static T SetDefaultSelection<T>(this T entity, int value)
            where T : FeatureDefinitionFeatureSet
        {
            entity.SetField("defaultSelection", value);
            return entity;
        }

        public static T SetEnumerateInDescription<T>(this T entity, bool value)
            where T : FeatureDefinitionFeatureSet
        {
            entity.SetField("enumerateInDescription", value);
            return entity;
        }

        public static T SetMode<T>(this T entity, FeatureDefinitionFeatureSet.FeatureSetMode value)
            where T : FeatureDefinitionFeatureSet
        {
            entity.SetField("mode", value);
            return entity;
        }

        public static T SetUniqueChoices<T>(this T entity, bool value)
            where T : FeatureDefinitionFeatureSet
        {
            entity.SetField("uniqueChoices", value);
            return entity;
        }
    }
}
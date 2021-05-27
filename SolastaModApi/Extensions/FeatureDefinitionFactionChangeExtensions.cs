using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionFactionChange))]
    public static class FeatureDefinitionFactionChangeExtensions
    {
        public static T SetChangeMode<T>(this T entity, FeatureDefinitionFactionChange.Mode value)
            where T : FeatureDefinitionFactionChange
        {
            entity.SetField("changeMode", value);
            return entity;
        }

        public static T SetSpecificFactionName<T>(this T entity, string value)
            where T : FeatureDefinitionFactionChange
        {
            entity.SetField("specificFactionName", value);
            return entity;
        }

        public static T SetTotalControl<T>(this T entity, bool value)
            where T : FeatureDefinitionFactionChange
        {
            entity.SetField("totalControl", value);
            return entity;
        }
    }
}
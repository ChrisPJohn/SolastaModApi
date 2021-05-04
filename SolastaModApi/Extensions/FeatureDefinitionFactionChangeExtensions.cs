using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
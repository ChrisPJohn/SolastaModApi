using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionSubclassChoiceExtensions
    {
        public static T SetFilterByDeity<T>(this T entity, bool value)
            where T : FeatureDefinitionSubclassChoice
        {
            entity.SetField("filterByDeity", value);
            return entity;
        }

        public static T SetSubclassSuffix<T>(this T entity, string value)
            where T : FeatureDefinitionSubclassChoice
        {
            entity.SetField("subclassSuffix", value);
            return entity;
        }
    }
}
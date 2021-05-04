using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class BestiaryStatsDefinitionExtensions
    {
        public static T SetLineHeight<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : BestiaryStatsDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}
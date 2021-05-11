using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionSchoolSavantExtensions
    {
        public static T SetReductionFactor<T>(this T entity, float value)
            where T : FeatureDefinitionSchoolSavant
        {
            entity.SetField("reductionFactor", value);
            return entity;
        }

        public static T SetSchoolOfMagic<T>(this T entity, string value)
            where T : FeatureDefinitionSchoolSavant
        {
            entity.SetField("schoolOfMagic", value);
            return entity;
        }
    }
}
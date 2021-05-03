using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
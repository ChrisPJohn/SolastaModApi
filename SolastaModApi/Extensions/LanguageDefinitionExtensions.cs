using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class LanguageDefinitionExtensions
    {
        public static T SetPersonalityAdditiveBase<T>(this T entity, int value)
            where T : LanguageDefinition
        {
            entity.SetField("personalityAdditiveBase", value);
            return entity;
        }

        public static T SetPersonalityFlag<T>(this T entity, bool value)
            where T : LanguageDefinition
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionLoreExpertiseExtensions
    {
        public static T SetExpertiseType<T>(this T entity, FeatureDefinitionLoreExpertise.ExpertiseType value)
            where T : FeatureDefinitionLoreExpertise
        {
            entity.SetField("expertiseType", value);
            return entity;
        }
    }
}
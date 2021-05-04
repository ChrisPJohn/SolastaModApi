using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class EncounterDefinitionExtensions
    {
        public static T SetChallengeRating<T>(this T entity, int value)
            where T : EncounterDefinition
        {
            entity.SetField("challengeRating", value);
            return entity;
        }

        public static T SetLocationOverride<T>(this T entity, LocationDefinition value)
            where T : EncounterDefinition
        {
            entity.SetField("locationOverride", value);
            return entity;
        }

        public static T SetType<T>(this T entity, EncounterDefinitions.Type value)
            where T : EncounterDefinition
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}
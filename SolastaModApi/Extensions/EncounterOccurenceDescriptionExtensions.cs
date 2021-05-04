using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class EncounterOccurenceDescriptionExtensions
    {
        public static T SetEncounterDefinition<T>(this T entity, EncounterDefinition value)
            where T : EncounterOccurenceDescription
        {
            entity.SetField("encounterDefinition", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, int value)
            where T : EncounterOccurenceDescription
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
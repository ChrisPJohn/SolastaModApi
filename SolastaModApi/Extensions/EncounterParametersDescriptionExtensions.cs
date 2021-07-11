using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EncounterParametersDescription))]
    public static partial class EncounterParametersDescriptionExtensions
    {
        public static T SetEncounterDefinition<T>(this T entity, EncounterDefinition value)
            where T : EncounterParametersDescription
        {
            entity.EncounterDefinition = value;
            return entity;
        }

        public static T SetLocationDefinition<T>(this T entity, LocationDefinition value)
            where T : EncounterParametersDescription
        {
            entity.LocationDefinition = value;
            return entity;
        }

        public static T SetPartyNavigating<T>(this T entity, bool value)
            where T : EncounterParametersDescription
        {
            entity.PartyNavigating = value;
            return entity;
        }

        public static T SetPartySurprised<T>(this T entity, bool value)
            where T : EncounterParametersDescription
        {
            entity.PartySurprised = value;
            return entity;
        }
    }
}
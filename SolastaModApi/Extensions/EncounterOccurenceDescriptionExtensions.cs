using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EncounterOccurenceDescription))]
    public static partial class EncounterOccurenceDescriptionExtensions
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
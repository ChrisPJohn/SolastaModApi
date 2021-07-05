using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(NarrativeEventDescription))]
    public static partial class NarrativeEventDescriptionExtensions
    {
        public static T SetOccurenceWeight<T>(this T entity, int value)
            where T : NarrativeEventDescription
        {
            entity.SetField("occurenceWeight", value);
            return entity;
        }

        public static T SetQuote<T>(this T entity, string value)
            where T : NarrativeEventDescription
        {
            entity.SetField("quote", value);
            return entity;
        }
    }
}
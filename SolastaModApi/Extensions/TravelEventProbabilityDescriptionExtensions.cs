using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TravelEventProbabilityDescription))]
    public static class TravelEventProbabilityDescriptionExtensions
    {
        public static T SetBasePercent<T>(this T entity, int value)
            where T : TravelEventProbabilityDescription
        {
            entity.SetField("basePercent", value);
            return entity;
        }

        public static T SetEventDefinition<T>(this T entity, TravelEventDefinition value)
            where T : TravelEventProbabilityDescription
        {
            entity.SetField("eventDefinition", value);
            return entity;
        }

        public static T SetIncremental<T>(this T entity, bool value)
            where T : TravelEventProbabilityDescription
        {
            entity.SetField("incremental", value);
            return entity;
        }
    }
}
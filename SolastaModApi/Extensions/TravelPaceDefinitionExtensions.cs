using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TravelPaceDefinition))]
    public static class TravelPaceDefinitionExtensions
    {
        public static T SetPerceptionModifier<T>(this T entity, int value)
            where T : TravelPaceDefinition
        {
            entity.SetField("perceptionModifier", value);
            return entity;
        }

        public static T SetTravelDistancePerHour<T>(this T entity, float value)
            where T : TravelPaceDefinition
        {
            entity.SetField("travelDistancePerHour", value);
            return entity;
        }
    }
}
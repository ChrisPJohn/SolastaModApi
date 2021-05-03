using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
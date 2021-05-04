using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TravelEventFixedOccurenceDescriptionExtensions
    {
        public static T SetEventDefinition<T>(this T entity, TravelEventDefinition value)
            where T : TravelEventFixedOccurenceDescription
        {
            entity.SetField("eventDefinition", value);
            return entity;
        }

        public static T SetFixedOccurence<T>(this T entity, TravelDefinitions.FixedOccurence value)
            where T : TravelEventFixedOccurenceDescription
        {
            entity.SetField("fixedOccurence", value);
            return entity;
        }
    }
}
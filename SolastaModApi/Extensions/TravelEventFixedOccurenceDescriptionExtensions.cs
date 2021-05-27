using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TravelEventFixedOccurenceDescription))]
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
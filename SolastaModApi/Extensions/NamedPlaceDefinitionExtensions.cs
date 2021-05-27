using SolastaModApi.Infrastructure;
using static RuleDefinitions;
using static GameCampaignDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(NamedPlaceDefinition))]
    public static class NamedPlaceDefinitionExtensions
    {
        public static T SetNamedPlaceType<T>(this T entity, NamedPlaceType value)
            where T : NamedPlaceDefinition
        {
            entity.SetField("namedPlaceType", value);
            return entity;
        }
    }
}
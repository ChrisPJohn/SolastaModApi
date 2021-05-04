using SolastaModApi.Infrastructure;
using static GameCampaignDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
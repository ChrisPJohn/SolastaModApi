using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CampaignNodeTypeDefinition))]
    public static class CampaignNodeTypeDefinitionExtensions
    {
        public static T SetGraphicsCampaignNodeReference<T>(this T entity, AssetReference value)
            where T : CampaignNodeTypeDefinition
        {
            entity.SetField("graphicsCampaignNodeReference", value);
            return entity;
        }
    }
}
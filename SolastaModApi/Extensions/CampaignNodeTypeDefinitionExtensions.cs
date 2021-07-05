using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CampaignNodeTypeDefinition))]
    public static partial class CampaignNodeTypeDefinitionExtensions
    {
        public static T SetGraphicsCampaignNodeReference<T>(this T entity, AssetReference value)
            where T : CampaignNodeTypeDefinition
        {
            entity.SetField("graphicsCampaignNodeReference", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCampaignNode))]
    public static class GuiCampaignNodeExtensions
    {
        public static T SetGameCampaignNode<T>(this T entity, GameCampaignNode value)
            where T : GuiCampaignNode
        {
            entity.SetField("gameCampaignNode", value);
            return entity;
        }

        public static T SetListing<T>(this T entity, string value)
            where T : GuiCampaignNode
        {
            entity.SetField("listing", value);
            return entity;
        }
    }
}
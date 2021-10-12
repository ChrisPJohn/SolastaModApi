using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCampaignNode))]
    public static partial class GuiCampaignNodeExtensions
    {
        public static T SetGameCampaignNode<T>(this T entity, GameCampaignNode value)
            where T : GuiCampaignNode
        {
            entity.SetField("gameCampaignNode", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CampaignRoleDescription))]
    public static partial class CampaignRoleDescriptionExtensions
    {
        public static T SetCampaignDefinitionName<T>(this T entity, string value)
            where T : CampaignRoleDescription
        {
            entity.CampaignDefinitionName = value;
            return entity;
        }

        public static T SetRoleNumber<T>(this T entity, int value)
            where T : CampaignRoleDescription
        {
            entity.RoleNumber = value;
            return entity;
        }
    }
}
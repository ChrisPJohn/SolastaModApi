using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(InventoryOperationDescription))]
    public static partial class InventoryOperationDescriptionExtensions
    {
        public static T SetCampaignDefinitionName<T>(this T entity, string value)
            where T : InventoryOperationDescription
        {
            entity.CampaignDefinitionName = value;
            return entity;
        }

        public static T SetGpValue<T>(this T entity, int value)
            where T : InventoryOperationDescription
        {
            entity.GpValue = value;
            return entity;
        }

        public static T SetItemDefinitionName<T>(this T entity, string value)
            where T : InventoryOperationDescription
        {
            entity.ItemDefinitionName = value;
            return entity;
        }

        public static T SetRoleNumber<T>(this T entity, int value)
            where T : InventoryOperationDescription
        {
            entity.RoleNumber = value;
            return entity;
        }

        public static T SetTarget<T>(this T entity, InventoryOperationDescription.OperationTarget value)
            where T : InventoryOperationDescription
        {
            entity.Target = value;
            return entity;
        }

        public static T SetType<T>(this T entity, string value)
            where T : InventoryOperationDescription
        {
            entity.Type = value;
            return entity;
        }
    }
}
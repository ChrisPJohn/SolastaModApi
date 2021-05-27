using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiEquipmentItem))]
    public static class GuiEquipmentItemExtensions
    {
        public static T SetCompareason<T>(this T entity, bool value)
            where T : GuiEquipmentItem
        {
            entity.SetField("compareason", value);
            return entity;
        }

        public static T SetEquipmentItem<T>(this T entity, RulesetItem value)
            where T : GuiEquipmentItem
        {
            entity.SetField("equipmentItem", value);
            return entity;
        }

        public static T SetGuiItemDefinition<T>(this T entity, GuiItemDefinition value)
            where T : GuiEquipmentItem
        {
            entity.SetField("guiItemDefinition", value);
            return entity;
        }

        public static T SetInventorySlot<T>(this T entity, RulesetInventorySlot value)
            where T : GuiEquipmentItem
        {
            entity.SetField("inventorySlot", value);
            return entity;
        }
    }
}
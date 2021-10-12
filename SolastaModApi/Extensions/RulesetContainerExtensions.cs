using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetContainer))]
    public static partial class RulesetContainerExtensions
    {
        public static T SetContainerContentModified<T>(this T entity, RulesetContainer.ContainerContentModifiedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("<ContainerContentModified>k__BackingField", value);
            return entity;
        }

        public static T SetHasBeenOpenedOnce<T>(this T entity, bool value)
            where T : RulesetContainer
        {
            entity.HasBeenOpenedOnce = value;
            return entity;
        }

        public static T SetIsRegisteringItem<T>(this T entity, bool value)
            where T : RulesetContainer
        {
            entity.SetField("isRegisteringItem", value);
            return entity;
        }

        public static T SetMinSlotsNumber<T>(this T entity, int value)
            where T : RulesetContainer
        {
            entity.SetField("minSlotsNumber", value);
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : RulesetContainer
        {
            entity.Name = value;
            return entity;
        }

        public static T SetOnItemEquiped<T>(this T entity, RulesetInventorySlot.ItemEquipedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemEquiped", value);
            return entity;
        }

        public static T SetOnItemReleased<T>(this T entity, RulesetInventorySlot.ItemReleasedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemReleased", value);
            return entity;
        }

        public static T SetOnItemUnequiped<T>(this T entity, RulesetInventorySlot.ItemUnequipedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemUnequiped", value);
            return entity;
        }
    }
}
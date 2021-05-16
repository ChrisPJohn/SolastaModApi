using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SlotTypeDefinition))]
    public static class SlotTypeDefinitionExtensions
    {
        public static T SetAlwaysLocked<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("alwaysLocked", value);
            return entity;
        }

        public static T SetBodySlot<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("bodySlot", value);
            return entity;
        }

        public static T SetCanDisplayArmor<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayArmor", value);
            return entity;
        }

        public static T SetCanDisplayArmorForPhoto<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayArmorForPhoto", value);
            return entity;
        }

        public static T SetCanDisplayLight<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayLight", value);
            return entity;
        }

        public static T SetCanStack<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canStack", value);
            return entity;
        }

        public static T SetDisplayArmorSortingIndex<T>(this T entity, int value)
            where T : SlotTypeDefinition
        {
            entity.SetField("displayArmorSortingIndex", value);
            return entity;
        }

        public static T SetHasDefaultVisual<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("hasDefaultVisual", value);
            return entity;
        }

        public static T SetLockedInBattle<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("lockedInBattle", value);
            return entity;
        }
    }
}
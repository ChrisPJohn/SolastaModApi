using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ItemGainDescription))]
    public static partial class ItemGainDescriptionExtensions
    {
        public static T SetDispatch<T>(this T entity, ItemGainDescription.DispatchType value)
            where T : ItemGainDescription
        {
            entity.Dispatch = value;
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : ItemGainDescription
        {
            entity.ItemDefinition = value;
            return entity;
        }

        public static T SetItemsNumber<T>(this T entity, int value)
            where T : ItemGainDescription
        {
            entity.ItemsNumber = value;
            return entity;
        }

        public static T SetLootPackDefinition<T>(this T entity, LootPackDefinition value)
            where T : ItemGainDescription
        {
            entity.LootPackDefinition = value;
            return entity;
        }

        public static T SetPackage<T>(this T entity, ItemGainDescription.PackageType value)
            where T : ItemGainDescription
        {
            entity.Package = value;
            return entity;
        }

        public static T SetRoleName<T>(this T entity, string value)
            where T : ItemGainDescription
        {
            entity.RoleName = value;
            return entity;
        }
    }
}
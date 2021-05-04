using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetItemExtensions
    {
        public static T SetGains<T>(this T entity, int[] value)
            where T : RulesetItem
        {
            entity.SetField("gains", value);
            return entity;
        }

        public static T SetItemDurationRefreshed<T>(this T entity, RulesetItem.ItemDurationRefreshedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemDurationRefreshed>k__BackingField", value);
            return entity;
        }

        public static T SetItemPropertyRemoved<T>(this T entity, RulesetItem.ItemPropertyRemovedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemPropertyRemoved>k__BackingField", value);
            return entity;
        }
    }
}
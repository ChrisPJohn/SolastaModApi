using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ItemOccurenceExtensions
    {
        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : ItemOccurence
        {
            entity.SetField("itemDefinition", value);
            return entity;
        }

        public static T SetItemMode<T>(this T entity, ItemOccurence.SelectionMode value)
            where T : ItemOccurence
        {
            entity.SetField("itemMode", value);
            return entity;
        }

        public static T SetTreasureTableDefinition<T>(this T entity, TreasureTableDefinition value)
            where T : ItemOccurence
        {
            entity.SetField("treasureTableDefinition", value);
            return entity;
        }
    }
}
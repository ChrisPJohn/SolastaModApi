using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class DailyLogDefinitionExtensions
    {
        public static T SetHeaderHeight<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("headerHeight", value);
            return entity;
        }

        public static T SetSubItemHeight<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("subItemHeight", value);
            return entity;
        }

        public static T SetSubItemSpacing<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("subItemSpacing", value);
            return entity;
        }

        public static T SetTableBottomMargin<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("tableBottomMargin", value);
            return entity;
        }
    }
}
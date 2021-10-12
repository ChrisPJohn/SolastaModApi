using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DailyLogDefinition))]
    public static partial class DailyLogDefinitionExtensions
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
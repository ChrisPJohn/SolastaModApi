using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class CalendarDefinitionExtensions
    {
        public static T SetDaysPerMonth<T>(this T entity, int value)
            where T : CalendarDefinition
        {
            entity.SetField("daysPerMonth", value);
            return entity;
        }

        public static T SetMonthsNames<T>(this T entity, string[] value)
            where T : CalendarDefinition
        {
            entity.SetField("monthsNames", value);
            return entity;
        }

        public static T SetMonthsPerYear<T>(this T entity, int value)
            where T : CalendarDefinition
        {
            entity.SetField("monthsPerYear", value);
            return entity;
        }

        public static T SetYearFormat<T>(this T entity, string value)
            where T : CalendarDefinition
        {
            entity.SetField("yearFormat", value);
            return entity;
        }

        public static T SetYearTags<T>(this T entity, CalendarDefinition.YearTag[] value)
            where T : CalendarDefinition
        {
            entity.SetField("yearTags", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class DateTimeDefinitionExtensions
    {
        public static T SetDay<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("day", value);
            return entity;
        }

        public static T SetHour<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("hour", value);
            return entity;
        }

        public static T SetMinute<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("minute", value);
            return entity;
        }

        public static T SetMonth<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("month", value);
            return entity;
        }

        public static T SetSeconds<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("seconds", value);
            return entity;
        }

        public static T SetYear<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("year", value);
            return entity;
        }
    }
}
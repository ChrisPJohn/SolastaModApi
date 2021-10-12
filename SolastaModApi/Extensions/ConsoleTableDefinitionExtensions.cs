using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ConsoleTableDefinition))]
    public static partial class ConsoleTableDefinitionExtensions
    {
        public static T SetIndentWidth<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("indentWidth", value);
            return entity;
        }

        public static T SetLineHeight<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}
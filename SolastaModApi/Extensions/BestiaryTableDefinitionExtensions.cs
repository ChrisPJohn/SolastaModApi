using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(BestiaryTableDefinition))]
    public static class BestiaryTableDefinitionExtensions
    {
        public static T SetCellHeight<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellHeight", value);
            return entity;
        }

        public static T SetCellWidth<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellWidth", value);
            return entity;
        }
    }
}
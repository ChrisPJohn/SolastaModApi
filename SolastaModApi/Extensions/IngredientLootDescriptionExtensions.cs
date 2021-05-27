using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(IngredientLootDescription))]
    public static class IngredientLootDescriptionExtensions
    {
        public static T SetCheckDC<T>(this T entity, int value)
            where T : IngredientLootDescription
        {
            entity.SetField("checkDC", value);
            return entity;
        }

        public static T SetTreasureTableDefinition<T>(this T entity, TreasureTableDefinition value)
            where T : IngredientLootDescription
        {
            entity.SetField("treasureTableDefinition", value);
            return entity;
        }
    }
}
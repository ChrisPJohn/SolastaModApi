using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RecipeDefinition))]
    public static class RecipeDefinitionExtensions
    {
        public static T SetCraftedItem<T>(this T entity, ItemDefinition value)
            where T : RecipeDefinition
        {
            entity.SetField("craftedItem", value);
            return entity;
        }

        public static T SetCraftingDC<T>(this T entity, int value)
            where T : RecipeDefinition
        {
            entity.SetField("craftingDC", value);
            return entity;
        }

        public static T SetCraftingHours<T>(this T entity, int value)
            where T : RecipeDefinition
        {
            entity.SetField("craftingHours", value);
            return entity;
        }

        public static T SetSpellDefinition<T>(this T entity, SpellDefinition value)
            where T : RecipeDefinition
        {
            entity.SetField("spellDefinition", value);
            return entity;
        }

        public static T SetStackCount<T>(this T entity, int value)
            where T : RecipeDefinition
        {
            entity.SetField("stackCount", value);
            return entity;
        }

        public static T SetToolTypeDefinition<T>(this T entity, ToolTypeDefinition value)
            where T : RecipeDefinition
        {
            entity.SetField("toolTypeDefinition", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiRecipeDefinition))]
    public static class GuiRecipeDefinitionExtensions
    {
        public static T SetRecipeDefinition<T>(this T entity, RecipeDefinition value)
            where T : GuiRecipeDefinition
        {
            entity.SetField("<RecipeDefinition>k__BackingField", value);
            return entity;
        }
    }
}
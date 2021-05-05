using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
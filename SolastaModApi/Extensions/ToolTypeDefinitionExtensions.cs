using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ToolTypeDefinitionExtensions
    {
        public static T SetCraftingAbilityScore<T>(this T entity, string value)
            where T : ToolTypeDefinition
        {
            entity.SetField("craftingAbilityScore", value);
            return entity;
        }

        public static T SetHasParentCategory<T>(this T entity, bool value)
            where T : ToolTypeDefinition
        {
            entity.SetField("hasParentCategory", value);
            return entity;
        }

        public static T SetToolCategory<T>(this T entity, string value)
            where T : ToolTypeDefinition
        {
            entity.SetField("toolCategory", value);
            return entity;
        }
    }
}
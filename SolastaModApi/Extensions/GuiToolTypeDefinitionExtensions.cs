using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiToolTypeDefinition))]
    public static class GuiToolTypeDefinitionExtensions
    {
        public static T SetToolTypeDefinition<T>(this T entity, ToolTypeDefinition value)
            where T : GuiToolTypeDefinition
        {
            entity.SetField("<ToolTypeDefinition>k__BackingField", value);
            return entity;
        }
    }
}
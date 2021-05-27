using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiBaseDefinitionWrapper))]
    public static class GuiBaseDefinitionWrapperExtensions
    {
        public static T SetBaseDefinition<T>(this T entity, BaseDefinition value)
            where T : GuiBaseDefinitionWrapper
        {
            entity.SetField("<BaseDefinition>k__BackingField", value);
            return entity;
        }
    }
}
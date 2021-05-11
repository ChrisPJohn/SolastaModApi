using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiItemDefinition))]
    public static class GuiItemDefinitionExtensions
    {
        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : GuiItemDefinition
        {
            entity.SetField("<ItemDefinition>k__BackingField", value);
            return entity;
        }
    }
}
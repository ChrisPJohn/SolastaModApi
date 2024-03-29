using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiEnvironmentEffectDefinition))]
    public static class GuiEnvironmentEffectDefinitionExtensions
    {
        public static T SetEnvironmentEffectDefinition<T>(this T entity, EnvironmentEffectDefinition value)
            where T : GuiEnvironmentEffectDefinition
        {
            entity.SetField("<EnvironmentEffectDefinition>k__BackingField", value);
            return entity;
        }
    }
}
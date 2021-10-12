using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiEffectProxyDefinition))]
    public static partial class GuiEffectProxyDefinitionExtensions
    {
        public static T SetEffectProxyDefinition<T>(this T entity, EffectProxyDefinition value)
            where T : GuiEffectProxyDefinition
        {
            entity.SetField("<EffectProxyDefinition>k__BackingField", value);
            return entity;
        }
    }
}
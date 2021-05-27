using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiSpellDefinition))]
    public static class GuiSpellDefinitionExtensions
    {
        public static T SetSpellDefinition<T>(this T entity, SpellDefinition value)
            where T : GuiSpellDefinition
        {
            entity.SetField("<SpellDefinition>k__BackingField", value);
            return entity;
        }
    }
}
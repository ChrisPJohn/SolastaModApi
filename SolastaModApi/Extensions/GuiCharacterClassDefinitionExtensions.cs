using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCharacterClassDefinition))]
    public static class GuiCharacterClassDefinitionExtensions
    {
        public static T SetCharacterClassDefinition<T>(this T entity, CharacterClassDefinition value)
            where T : GuiCharacterClassDefinition
        {
            entity.SetField("<CharacterClassDefinition>k__BackingField", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCharacterRaceDefinition))]
    public static partial class GuiCharacterRaceDefinitionExtensions
    {
        public static T SetCharacterRaceDefinition<T>(this T entity, CharacterRaceDefinition value)
            where T : GuiCharacterRaceDefinition
        {
            entity.SetField("<CharacterRaceDefinition>k__BackingField", value);
            return entity;
        }
    }
}
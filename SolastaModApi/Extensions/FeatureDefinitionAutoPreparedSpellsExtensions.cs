using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAutoPreparedSpells))]
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static T SetSpellcastingClass<T>(this T entity, CharacterClassDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            entity.SetField("spellcastingClass", value);
            return entity;
        }
    }
}
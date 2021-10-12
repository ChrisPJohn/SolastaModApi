using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAutoPreparedSpells))]
    public static partial class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static T SetAffinityRace<T>(this T entity, CharacterRaceDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            entity.SetField("affinityRace", value);
            return entity;
        }

        public static T SetAutopreparedTag<T>(this T entity, string value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            entity.SetField("autopreparedTag", value);
            return entity;
        }

        public static T SetSpellcastingClass<T>(this T entity, CharacterClassDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            entity.SetField("spellcastingClass", value);
            return entity;
        }
    }
}
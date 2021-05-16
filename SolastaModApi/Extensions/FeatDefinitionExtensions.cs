using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatDefinition))]
    public static class FeatDefinitionExtensions
    {
        public static T SetArmorProficiencyCategory<T>(this T entity, string value)
            where T : FeatDefinition
        {
            entity.SetField("armorProficiencyCategory", value);
            return entity;
        }

        public static T SetArmorProficiencyPrerequisite<T>(this T entity, bool value)
            where T : FeatDefinition
        {
            entity.SetField("armorProficiencyPrerequisite", value);
            return entity;
        }

        public static T SetMinimalAbilityScoreName<T>(this T entity, string value)
            where T : FeatDefinition
        {
            entity.SetField("minimalAbilityScoreName", value);
            return entity;
        }

        public static T SetMinimalAbilityScorePrerequisite<T>(this T entity, bool value)
            where T : FeatDefinition
        {
            entity.SetField("minimalAbilityScorePrerequisite", value);
            return entity;
        }

        public static T SetMinimalAbilityScoreValue<T>(this T entity, int value)
            where T : FeatDefinition
        {
            entity.SetField("minimalAbilityScoreValue", value);
            return entity;
        }

        public static T SetMustCastSpellsPrerequisite<T>(this T entity, bool value)
            where T : FeatDefinition
        {
            entity.SetField("mustCastSpellsPrerequisite", value);
            return entity;
        }
    }
}
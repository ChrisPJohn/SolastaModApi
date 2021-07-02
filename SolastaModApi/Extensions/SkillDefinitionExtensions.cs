using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SkillDefinition))]
    public static partial class SkillDefinitionExtensions
    {
        public static T SetAbilityScore<T>(this T entity, string value)
            where T : SkillDefinition
        {
            entity.SetField("abilityScore", value);
            return entity;
        }

        public static T SetPersonalityAdditiveBase<T>(this T entity, int value)
            where T : SkillDefinition
        {
            entity.SetField("personalityAdditiveBase", value);
            return entity;
        }

        public static T SetPersonalityFlag<T>(this T entity, bool value)
            where T : SkillDefinition
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }
    }
}
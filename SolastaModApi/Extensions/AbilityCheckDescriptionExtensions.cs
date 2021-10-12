using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(AbilityCheckDescription))]
    public static partial class AbilityCheckDescriptionExtensions
    {
        public static T SetAbilityScoreName<T>(this T entity, string value)
            where T : AbilityCheckDescription
        {
            entity.AbilityScoreName = value;
            return entity;
        }

        public static T SetAffinity<T>(this T entity, AdvantageType value)
            where T : AbilityCheckDescription
        {
            entity.Affinity = value;
            return entity;
        }

        public static T SetDifficultyClass<T>(this T entity, int value)
            where T : AbilityCheckDescription
        {
            entity.DifficultyClass = value;
            return entity;
        }

        public static T SetMinRoll<T>(this T entity, int value)
            where T : AbilityCheckDescription
        {
            entity.MinRoll = value;
            return entity;
        }

        public static T SetProficiencyName<T>(this T entity, string value)
            where T : AbilityCheckDescription
        {
            entity.ProficiencyName = value;
            return entity;
        }

        public static T SetSilent<T>(this T entity, bool value)
            where T : AbilityCheckDescription
        {
            entity.Silent = value;
            return entity;
        }
    }
}
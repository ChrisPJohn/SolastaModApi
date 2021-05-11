using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EffectAIParameters))]
    public static class EffectAIParametersExtensions
    {
        public static T SetAoeScoreMultiplier<T>(this T entity, float value)
            where T : EffectAIParameters
        {
            entity.SetField("aoeScoreMultiplier", value);
            return entity;
        }

        public static T SetCooldownForBattle<T>(this T entity, int value)
            where T : EffectAIParameters
        {
            entity.SetField("cooldownForBattle", value);
            return entity;
        }

        public static T SetCooldownForCaster<T>(this T entity, int value)
            where T : EffectAIParameters
        {
            entity.SetField("cooldownForCaster", value);
            return entity;
        }

        public static T SetDynamicCooldown<T>(this T entity, bool value)
            where T : EffectAIParameters
        {
            entity.SetField("dynamicCooldown", value);
            return entity;
        }
    }
}
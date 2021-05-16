using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(KillForm))]
    public static class KillFormExtensions
    {
        public static T SetChallengeRating<T>(this T entity, float value)
            where T : KillForm
        {
            entity.SetField("challengeRating", value);
            return entity;
        }

        public static T SetHitPoints<T>(this T entity, int value)
            where T : KillForm
        {
            entity.SetField("hitPoints", value);
            return entity;
        }

        public static T SetKillCondition<T>(this T entity, KillCondition value)
            where T : KillForm
        {
            entity.SetField("killCondition", value);
            return entity;
        }
    }
}
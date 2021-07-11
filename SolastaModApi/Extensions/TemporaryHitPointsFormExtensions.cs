using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TemporaryHitPointsForm))]
    public static partial class TemporaryHitPointsFormExtensions
    {
        public static T SetBonusHitPoints<T>(this T entity, int value)
            where T : TemporaryHitPointsForm
        {
            entity.BonusHitPoints = value;
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, int value)
            where T : TemporaryHitPointsForm
        {
            entity.DiceNumber = value;
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : TemporaryHitPointsForm
        {
            entity.DieType = value;
            return entity;
        }
    }
}
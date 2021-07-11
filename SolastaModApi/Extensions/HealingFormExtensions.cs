using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(HealingForm))]
    public static partial class HealingFormExtensions
    {
        public static T SetBonusHealing<T>(this T entity, int value)
            where T : HealingForm
        {
            entity.BonusHealing = value;
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, int value)
            where T : HealingForm
        {
            entity.DiceNumber = value;
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : HealingForm
        {
            entity.DieType = value;
            return entity;
        }

        public static T SetHealingCap<T>(this T entity, HealingCap value)
            where T : HealingForm
        {
            entity.HealingCap = value;
            return entity;
        }

        public static T SetHealingComputation<T>(this T entity, HealingComputation value)
            where T : HealingForm
        {
            entity.HealingComputation = value;
            return entity;
        }

        public static T SetVariablePool<T>(this T entity, bool value)
            where T : HealingForm
        {
            entity.VariablePool = value;
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DamageForm))]
    public static partial class DamageFormExtensions
    {
        public static T SetBonusDamage<T>(this T entity, int value)
            where T : DamageForm
        {
            entity.BonusDamage = value;
            return entity;
        }

        public static T SetDamageType<T>(this T entity, string value)
            where T : DamageForm
        {
            entity.DamageType = value;
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, int value)
            where T : DamageForm
        {
            entity.DiceNumber = value;
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : DamageForm
        {
            entity.DieType = value;
            return entity;
        }

        public static T SetForceKillOnZeroHp<T>(this T entity, bool value)
            where T : DamageForm
        {
            entity.SetField("forceKillOnZeroHp", value);
            return entity;
        }

        public static T SetHealFromInflictedDamage<T>(this T entity, HealFromInflictedDamage value)
            where T : DamageForm
        {
            entity.SetField("healFromInflictedDamage", value);
            return entity;
        }

        public static T SetHitPointsFloor<T>(this T entity, int value)
            where T : DamageForm
        {
            entity.SetField("hitPointsFloor", value);
            return entity;
        }

        public static T SetSpecialDeathCondition<T>(this T entity, ConditionDefinition value)
            where T : DamageForm
        {
            entity.SetField("specialDeathCondition", value);
            return entity;
        }

        public static T SetVersatile<T>(this T entity, bool value)
            where T : DamageForm
        {
            entity.SetField("versatile", value);
            return entity;
        }

        public static T SetVersatileDieType<T>(this T entity, DieType value)
            where T : DamageForm
        {
            entity.VersatileDieType = value;
            return entity;
        }
    }
}
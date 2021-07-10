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
    }
}
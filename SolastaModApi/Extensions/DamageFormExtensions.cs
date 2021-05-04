using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class DamageFormExtensions
    {
        public static T SetHealFromInflictedDamage<T>(this T entity, HealFromInflictedDamage value)
            where T : DamageForm
        {
            entity.SetField("healFromInflictedDamage", value);
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
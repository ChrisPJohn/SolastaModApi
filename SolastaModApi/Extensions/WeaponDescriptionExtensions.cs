using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WeaponDescription))]
    public static class WeaponDescriptionExtensions
    {
        public static T SetAmmunitionType<T>(this T entity, string value)
            where T : WeaponDescription
        {
            entity.SetField("ammunitionType", value);
            return entity;
        }

        public static T SetCloseRange<T>(this T entity, int value)
            where T : WeaponDescription
        {
            entity.SetField("closeRange", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : WeaponDescription
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetMaxRange<T>(this T entity, int value)
            where T : WeaponDescription
        {
            entity.SetField("maxRange", value);
            return entity;
        }

        public static T SetReachRange<T>(this T entity, int value)
            where T : WeaponDescription
        {
            entity.SetField("reachRange", value);
            return entity;
        }

        public static T SetWeaponType<T>(this T entity, string value)
            where T : WeaponDescription
        {
            entity.SetField("weaponType", value);
            return entity;
        }
    }
}
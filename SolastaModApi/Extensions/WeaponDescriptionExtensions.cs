using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
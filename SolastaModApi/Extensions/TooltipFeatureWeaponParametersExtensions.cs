using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeatureWeaponParametersExtensions
    {
        public static T SetAttackModifiersTable<T>(this T entity, RectTransform value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("attackModifiersTable", value);
            return entity;
        }

        public static T SetDamageModifierGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("damageModifierGroup", value);
            return entity;
        }

        public static T SetDamageModifierValue<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("damageModifierValue", value);
            return entity;
        }

        public static T SetHitModifierGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("hitModifierGroup", value);
            return entity;
        }

        public static T SetHitModifierValue<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("hitModifierValue", value);
            return entity;
        }

        public static T SetMasterTable<T>(this T entity, RectTransform value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("masterTable", value);
            return entity;
        }

        public static T SetStatsColumns<T>(this T entity, FeatureElementInfoColumn[] value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("statsColumns", value);
            return entity;
        }

        public static T SetStatsGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureWeaponParameters
        {
            entity.SetField("statsGroup", value);
            return entity;
        }
    }
}
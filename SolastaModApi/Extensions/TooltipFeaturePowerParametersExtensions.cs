using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeaturePowerParametersExtensions
    {
        public static T SetActivationTimeLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("activationTimeLabel", value);
            return entity;
        }

        public static T SetBottomGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("bottomGroup", value);
            return entity;
        }

        public static T SetDurationLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("durationLabel", value);
            return entity;
        }

        public static T SetRechargeLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("rechargeLabel", value);
            return entity;
        }

        public static T SetSavingThrowHeader<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("savingThrowHeader", value);
            return entity;
        }

        public static T SetSavingThrowLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("savingThrowLabel", value);
            return entity;
        }

        public static T SetUsesLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("usesLabel", value);
            return entity;
        }

        public static T SetVerticalLayout<T>(this T entity, RectTransform value)
            where T : TooltipFeaturePowerParameters
        {
            entity.SetField("verticalLayout", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeatureDeviceParametersExtensions
    {
        public static T SetAttunementLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureDeviceParameters
        {
            entity.SetField("attunementLabel", value);
            return entity;
        }

        public static T SetRechargeHeader<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureDeviceParameters
        {
            entity.SetField("rechargeHeader", value);
            return entity;
        }

        public static T SetRechargeLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureDeviceParameters
        {
            entity.SetField("rechargeLabel", value);
            return entity;
        }

        public static T SetUsageGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureDeviceParameters
        {
            entity.SetField("usageGroup", value);
            return entity;
        }

        public static T SetUsageLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureDeviceParameters
        {
            entity.SetField("usageLabel", value);
            return entity;
        }
    }
}
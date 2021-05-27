using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureDeviceParameters))]
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
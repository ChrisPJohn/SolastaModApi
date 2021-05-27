using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.UI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureSpellParameters))]
    public static class TooltipFeatureSpellParametersExtensions
    {
        public static T SetCastingTimeLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("castingTimeLabel", value);
            return entity;
        }

        public static T SetDurationLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("durationLabel", value);
            return entity;
        }

        public static T SetInvalidColor<T>(this T entity, Color value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("invalidColor", value);
            return entity;
        }

        public static T SetMaterialComponentMarker<T>(this T entity, Image value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("materialComponentMarker", value);
            return entity;
        }

        public static T SetMaterialSpecificLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("materialSpecificLabel", value);
            return entity;
        }

        public static T SetSavingThrowHeader<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("savingThrowHeader", value);
            return entity;
        }

        public static T SetSavingThrowLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("savingThrowLabel", value);
            return entity;
        }

        public static T SetSomaticComponentMarker<T>(this T entity, Image value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("somaticComponentMarker", value);
            return entity;
        }

        public static T SetSpecificComponentMarker<T>(this T entity, Image value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("specificComponentMarker", value);
            return entity;
        }

        public static T SetValidColor<T>(this T entity, Color value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("validColor", value);
            return entity;
        }

        public static T SetVerbalComponentMarker<T>(this T entity, Image value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("verbalComponentMarker", value);
            return entity;
        }

        public static T SetVerticalLayout<T>(this T entity, RectTransform value)
            where T : TooltipFeatureSpellParameters
        {
            entity.SetField("verticalLayout", value);
            return entity;
        }
    }
}
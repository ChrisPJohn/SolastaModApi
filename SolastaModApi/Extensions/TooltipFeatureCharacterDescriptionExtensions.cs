using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.UI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureCharacterDescription))]
    public static class TooltipFeatureCharacterDescriptionExtensions
    {
        public static T SetActionLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("actionLabel", value);
            return entity;
        }

        public static T SetCoverFullImage<T>(this T entity, Image value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("coverFullImage", value);
            return entity;
        }

        public static T SetCoverGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("coverGroup", value);
            return entity;
        }

        public static T SetCoverHalfImage<T>(this T entity, Image value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("coverHalfImage", value);
            return entity;
        }

        public static T SetCoverLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("coverLabel", value);
            return entity;
        }

        public static T SetCoverThreeQuarterImage<T>(this T entity, Image value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("coverThreeQuarterImage", value);
            return entity;
        }

        public static T SetHeaderLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureCharacterDescription
        {
            entity.SetField("headerLabel", value);
            return entity;
        }
    }
}
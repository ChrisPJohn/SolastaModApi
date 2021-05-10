using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiTooltipClassDefinitionExtensions
    {
        public static T SetPanelWidth<T>(this T entity, float value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("panelWidth", value);
            return entity;
        }

        public static T SetShowDelay<T>(this T entity, float value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("showDelay", value);
            return entity;
        }

        public static T SetTooltipPanelPrefab<T>(this T entity, GameObject value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("tooltipPanelPrefab", value);
            return entity;
        }
    }
}
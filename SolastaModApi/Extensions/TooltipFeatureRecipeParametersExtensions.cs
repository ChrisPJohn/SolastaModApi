using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureRecipeParameters))]
    public static class TooltipFeatureRecipeParametersExtensions
    {
        public static T SetCraftingDCLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureRecipeParameters
        {
            entity.SetField("craftingDCLabel", value);
            return entity;
        }

        public static T SetCraftingHoursLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureRecipeParameters
        {
            entity.SetField("craftingHoursLabel", value);
            return entity;
        }
    }
}
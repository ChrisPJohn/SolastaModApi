using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureSpellbookParameters))]
    public static class TooltipFeatureSpellbookParametersExtensions
    {
        public static T SetDescriptionLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureSpellbookParameters
        {
            entity.SetField("descriptionLabel", value);
            return entity;
        }
    }
}
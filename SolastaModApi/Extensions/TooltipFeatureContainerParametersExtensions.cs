using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureContainerParameters))]
    public static partial class TooltipFeatureContainerParametersExtensions
    {
        public static T SetWeightCapacityLabel<T>(this T entity, GuiLabel value)
            where T : TooltipFeatureContainerParameters
        {
            entity.SetField("weightCapacityLabel", value);
            return entity;
        }
    }
}
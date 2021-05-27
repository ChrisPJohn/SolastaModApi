using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiActiveCondition))]
    public static class GuiActiveConditionExtensions
    {
        public static T SetActiveCondition<T>(this T entity, RulesetCondition value)
            where T : GuiActiveCondition
        {
            entity.SetField("activeCondition", value);
            return entity;
        }

        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : GuiActiveCondition
        {
            entity.SetField("conditionDefinition", value);
            return entity;
        }
    }
}
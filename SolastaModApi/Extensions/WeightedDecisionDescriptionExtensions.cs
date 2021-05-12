using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WeightedDecisionDescription))]
    public static class WeightedDecisionDescriptionExtensions
    {
        public static T SetCooldown<T>(this T entity, int value)
            where T : WeightedDecisionDescription
        {
            entity.SetField("cooldown", value);
            return entity;
        }

        public static T SetDecision<T>(this T entity, DecisionDefinition value)
            where T : WeightedDecisionDescription
        {
            entity.SetField("decision", value);
            return entity;
        }

        public static T SetDynamicCooldown<T>(this T entity, bool value)
            where T : WeightedDecisionDescription
        {
            entity.SetField("dynamicCooldown", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : WeightedDecisionDescription
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DecisionDefinition))]
    public static class DecisionDefinitionExtensions
    {
        public static T SetDecision<T>(this T entity, DecisionDescription value)
            where T : DecisionDefinition
        {
            entity.SetField("decision", value);
            return entity;
        }
    }
}
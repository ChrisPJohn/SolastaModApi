using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
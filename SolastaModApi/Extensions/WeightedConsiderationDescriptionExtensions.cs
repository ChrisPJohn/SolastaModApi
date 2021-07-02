using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WeightedConsiderationDescription))]
    public static partial class WeightedConsiderationDescriptionExtensions
    {
        public static T SetConsideration<T>(this T entity, ConsiderationDefinition value)
            where T : WeightedConsiderationDescription
        {
            entity.SetField("consideration", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : WeightedConsiderationDescription
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
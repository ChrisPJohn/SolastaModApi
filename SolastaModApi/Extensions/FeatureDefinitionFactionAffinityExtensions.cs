using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionFactionAffinity))]
    public static partial class FeatureDefinitionFactionAffinityExtensions
    {
        public static T SetOperation<T>(this T entity, FactionOperationDescription value)
            where T : FeatureDefinitionFactionAffinity
        {
            entity.SetField("operation", value);
            return entity;
        }
    }
}
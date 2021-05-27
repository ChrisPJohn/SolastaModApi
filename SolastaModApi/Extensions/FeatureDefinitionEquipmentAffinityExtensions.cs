using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionEquipmentAffinity))]
    public static class FeatureDefinitionEquipmentAffinityExtensions
    {
        public static T SetAdditionalCarryingCapacity<T>(this T entity, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            entity.SetField("additionalCarryingCapacity", value);
            return entity;
        }

        public static T SetCarryingCapacityMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionEquipmentAffinity
        {
            entity.SetField("carryingCapacityMultiplier", value);
            return entity;
        }
    }
}
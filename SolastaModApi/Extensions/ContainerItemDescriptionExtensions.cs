using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ContainerItemDescription))]
    public static class ContainerItemDescriptionExtensions
    {
        public static T SetMinSlotsNumber<T>(this T entity, int value)
            where T : ContainerItemDescription
        {
            entity.SetField("minSlotsNumber", value);
            return entity;
        }

        public static T SetPersonalContainer<T>(this T entity, bool value)
            where T : ContainerItemDescription
        {
            entity.SetField("personalContainer", value);
            return entity;
        }

        public static T SetSlotsPerRow<T>(this T entity, int value)
            where T : ContainerItemDescription
        {
            entity.SetField("slotsPerRow", value);
            return entity;
        }

        public static T SetWeightCapacity<T>(this T entity, float value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightCapacity", value);
            return entity;
        }

        public static T SetWeightCapacityMultiplier<T>(this T entity, float value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightCapacityMultiplier", value);
            return entity;
        }

        public static T SetWeightComputationMethod<T>(this T entity, ContainerItemDescription.WeightComputation value)
            where T : ContainerItemDescription
        {
            entity.SetField("weightComputationMethod", value);
            return entity;
        }
    }
}
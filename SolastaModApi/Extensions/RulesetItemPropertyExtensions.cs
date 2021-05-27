using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetItemProperty))]
    public static class RulesetItemPropertyExtensions
    {
        public static T SetFeatureDefinition<T>(this T entity, FeatureDefinition value)
            where T : RulesetItemProperty
        {
            entity.SetField("featureDefinition", value);
            return entity;
        }

        public static T SetRemainingRounds<T>(this T entity, int value)
            where T : RulesetItemProperty
        {
            entity.SetField("<RemainingRounds>k__BackingField", value);
            return entity;
        }

        public static T SetTargetItemGuid<T>(this T entity, ulong value)
            where T : RulesetItemProperty
        {
            entity.SetField("targetItemGuid", value);
            return entity;
        }

        public static T SetUnicityTag<T>(this T entity, string value)
            where T : RulesetItemProperty
        {
            entity.SetField("unicityTag", value);
            return entity;
        }

        public static T SetUsageLimitation<T>(this T entity, ItemPropertyUsage value)
            where T : RulesetItemProperty
        {
            entity.SetField("usageLimitation", value);
            return entity;
        }
    }
}
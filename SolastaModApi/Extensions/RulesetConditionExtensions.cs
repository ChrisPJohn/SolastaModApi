using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCondition))]
    public static partial class RulesetConditionExtensions
    {
        public static T SetAmount<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.Amount = value;
            return entity;
        }

        public static T SetCanSaveToCancel<T>(this T entity, bool value)
            where T : RulesetCondition
        {
            entity.CanSaveToCancel = value;
            return entity;
        }

        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : RulesetCondition
        {
            entity.ConditionDefinition = value;
            return entity;
        }

        public static T SetDurationChanged<T>(this T entity, RulesetCondition.DurationChangedHandler value)
            where T : RulesetCondition
        {
            entity.SetField("<DurationChanged>k__BackingField", value);
            return entity;
        }

        public static T SetDurationParameter<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SetField("durationParameter", value);
            return entity;
        }

        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : RulesetCondition
        {
            entity.SetField("durationType", value);
            return entity;
        }

        public static T SetEffectDefinitionName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SetField("effectDefinitionName", value);
            return entity;
        }

        public static T SetEffectLevel<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SetField("effectLevel", value);
            return entity;
        }

        public static T SetEndOccurence<T>(this T entity, TurnOccurenceType value)
            where T : RulesetCondition
        {
            entity.EndOccurence = value;
            return entity;
        }

        public static T SetHasSaveOverride<T>(this T entity, bool value)
            where T : RulesetCondition
        {
            entity.HasSaveOverride = value;
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.Name = value;
            return entity;
        }

        public static T SetRemainingRounds<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.RemainingRounds = value;
            return entity;
        }

        public static T SetSaveOverrideAbilityScoreName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SaveOverrideAbilityScoreName = value;
            return entity;
        }

        public static T SetSaveOverrideDC<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SaveOverrideDC = value;
            return entity;
        }

        public static T SetSaveOverrideSourceName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SaveOverrideSourceName = value;
            return entity;
        }

        public static T SetSaveOverrideSourceType<T>(this T entity, FeatureSourceType value)
            where T : RulesetCondition
        {
            entity.SaveOverrideSourceType = value;
            return entity;
        }

        public static T SetSourceAbilityBonus<T>(this T entity, int value)
            where T : RulesetCondition
        {
            entity.SourceAbilityBonus = value;
            return entity;
        }

        public static T SetSourceFactionName<T>(this T entity, string value)
            where T : RulesetCondition
        {
            entity.SetField("sourceFactionName", value);
            return entity;
        }

        public static T SetSourceGuid<T>(this T entity, ulong value)
            where T : RulesetCondition
        {
            entity.SetField("sourceGuid", value);
            return entity;
        }

        public static T SetTargetGuid<T>(this T entity, ulong value)
            where T : RulesetCondition
        {
            entity.TargetGuid = value;
            return entity;
        }
    }
}
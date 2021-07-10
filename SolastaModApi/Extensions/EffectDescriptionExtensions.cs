using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EffectDescription))]
    public static partial class EffectDescriptionExtensions
    {
        public static T SetAnimationMagicEffect<T>(this T entity, AnimationMagicEffect value)
            where T : EffectDescription
        {
            entity.SetField("animationMagicEffect", value);
            return entity;
        }

        public static T SetCanBeDispersed<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("canBeDispersed", value);
            return entity;
        }

        public static T SetCanBePlacedOnCharacter<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("canBePlacedOnCharacter", value);
            return entity;
        }

        public static T SetCreatedByCharacter<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("createdByCharacter", value);
            return entity;
        }

        public static T SetDifficultyClassComputation<T>(this T entity, EffectDifficultyClassComputation value)
            where T : EffectDescription
        {
            entity.SetField("difficultyClassComputation", value);
            return entity;
        }

        public static T SetDisableSavingThrowOnAllies<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("disableSavingThrowOnAllies", value);
            return entity;
        }

        public static T SetEffectAdvancement<T>(this T entity, EffectAdvancement value)
            where T : EffectDescription
        {
            entity.SetField("effectAdvancement", value);
            return entity;
        }

        public static T SetEffectAIParameters<T>(this T entity, EffectAIParameters value)
            where T : EffectDescription
        {
            entity.SetField("effectAIParameters", value);
            return entity;
        }

        public static T SetEffectParticleParameters<T>(this T entity, EffectParticleParameters value)
            where T : EffectDescription
        {
            entity.SetField("effectParticleParameters", value);
            return entity;
        }

        public static T SetEffectPoolAmount<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("effectPoolAmount", value);
            return entity;
        }

        public static T SetEmissiveBorder<T>(this T entity, EmissiveBorder value)
            where T : EffectDescription
        {
            entity.SetField("emissiveBorder", value);
            return entity;
        }

        public static T SetEmissiveParameter<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("emissiveParameter", value);
            return entity;
        }

        public static T SetEndOfEffect<T>(this T entity, TurnOccurenceType value)
            where T : EffectDescription
        {
            entity.SetField("endOfEffect", value);
            return entity;
        }

        public static T SetHalfDamageOnAMiss<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("halfDamageOnAMiss", value);
            return entity;
        }

        public static T SetHasLimitedEffectPool<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("hasLimitedEffectPool", value);
            return entity;
        }

        public static T SetHasShoveRoll<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("hasShoveRoll", value);
            return entity;
        }

        public static T SetHasVelocity<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("hasVelocity", value);
            return entity;
        }

        public static T SetInviteOptionalAlly<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("inviteOptionalAlly", value);
            return entity;
        }

        public static T SetItemSelectionType<T>(this T entity, ItemSelectionType value)
            where T : EffectDescription
        {
            entity.SetField("itemSelectionType", value);
            return entity;
        }

        public static T SetOffsetImpactTimeBasedOnDistance<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("offsetImpactTimeBasedOnDistance", value);
            return entity;
        }

        public static T SetOffsetImpactTimeBasedOnDistanceFactor<T>(this T entity, float value)
            where T : EffectDescription
        {
            entity.SetField("offsetImpactTimeBasedOnDistanceFactor", value);
            return entity;
        }

        public static T SetOffsetImpactTimePerTarget<T>(this T entity, float value)
            where T : EffectDescription
        {
            entity.SetField("offsetImpactTimePerTarget", value);
            return entity;
        }

        public static T SetPoolFilterDiceNumber<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("poolFilterDiceNumber", value);
            return entity;
        }

        public static T SetPoolFilterDieType<T>(this T entity, DieType value)
            where T : EffectDescription
        {
            entity.SetField("poolFilterDieType", value);
            return entity;
        }

        public static T SetRangeParameter<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("rangeParameter", value);
            return entity;
        }

        public static T SetRecurrentEffect<T>(this T entity, RecurrentEffect value)
            where T : EffectDescription
        {
            entity.SetField("recurrentEffect", value);
            return entity;
        }

        public static T SetRequiresTargetProximity<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("requiresTargetProximity", value);
            return entity;
        }

        public static T SetRequiresVisibilityForPosition<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("requiresVisibilityForPosition", value);
            return entity;
        }

        public static T SetRetargetActionType<T>(this T entity, ActionType value)
            where T : EffectDescription
        {
            entity.SetField("retargetActionType", value);
            return entity;
        }

        public static T SetRetargetAfterDeath<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("retargetAfterDeath", value);
            return entity;
        }

        public static T SetSavingThrowDifficultyAbility<T>(this T entity, string value)
            where T : EffectDescription
        {
            entity.SetField("savingThrowDifficultyAbility", value);
            return entity;
        }

        public static T SetSpeedParameter<T>(this T entity, float value)
            where T : EffectDescription
        {
            entity.SetField("speedParameter", value);
            return entity;
        }

        public static T SetSpeedType<T>(this T entity, SpeedType value)
            where T : EffectDescription
        {
            entity.SetField("speedType", value);
            return entity;
        }

        public static T SetTargetConditionAsset<T>(this T entity, ConditionDefinition value)
            where T : EffectDescription
        {
            entity.SetField("targetConditionAsset", value);
            return entity;
        }

        public static T SetTargetConditionName<T>(this T entity, string value)
            where T : EffectDescription
        {
            entity.SetField("targetConditionName", value);
            return entity;
        }

        public static T SetTargetExcludeCaster<T>(this T entity, bool value)
            where T : EffectDescription
        {
            entity.SetField("targetExcludeCaster", value);
            return entity;
        }

        public static T SetTargetFilteringMethod<T>(this T entity, TargetFilteringMethod value)
            where T : EffectDescription
        {
            entity.SetField("targetFilteringMethod", value);
            return entity;
        }

        public static T SetTargetFilteringTag<T>(this T entity, TargetFilteringTag value)
            where T : EffectDescription
        {
            entity.SetField("targetFilteringTag", value);
            return entity;
        }

        public static T SetTargetParameter<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("targetParameter", value);
            return entity;
        }

        public static T SetTargetParameter2<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("targetParameter2", value);
            return entity;
        }

        public static T SetTargetProximityDistance<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("targetProximityDistance", value);
            return entity;
        }

        public static T SetTrapRangeType<T>(this T entity, TrapRangeType value)
            where T : EffectDescription
        {
            entity.SetField("trapRangeType", value);
            return entity;
        }

        public static T SetVelocityCellsPerRound<T>(this T entity, int value)
            where T : EffectDescription
        {
            entity.SetField("velocityCellsPerRound", value);
            return entity;
        }

        public static T SetVelocityType<T>(this T entity, VelocityType value)
            where T : EffectDescription
        {
            entity.SetField("velocityType", value);
            return entity;
        }
    }
}
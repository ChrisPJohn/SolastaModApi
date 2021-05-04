using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class EffectDescriptionExtensions
    {
        public static T SetDifficultyClassComputation<T>(this T entity, EffectDifficultyClassComputation value)
            where T : EffectDescription
        {
            entity.SetField("difficultyClassComputation", value);
            return entity;
        }

        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : EffectDescription
        {
            entity.SetField("durationType", value);
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

        public static T SetEmissiveBorder<T>(this T entity, EmissiveBorder value)
            where T : EffectDescription
        {
            entity.SetField("emissiveBorder", value);
            return entity;
        }

        public static T SetEndOfEffect<T>(this T entity, TurnOccurenceType value)
            where T : EffectDescription
        {
            entity.SetField("endOfEffect", value);
            return entity;
        }

        public static T SetItemSelectionType<T>(this T entity, ItemSelectionType value)
            where T : EffectDescription
        {
            entity.SetField("itemSelectionType", value);
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

        public static T SetPoolFilterDieType<T>(this T entity, DieType value)
            where T : EffectDescription
        {
            entity.SetField("poolFilterDieType", value);
            return entity;
        }

        public static T SetRangeType<T>(this T entity, RangeType value)
            where T : EffectDescription
        {
            entity.SetField("rangeType", value);
            return entity;
        }

        public static T SetRecurrentEffect<T>(this T entity, RecurrentEffect value)
            where T : EffectDescription
        {
            entity.SetField("recurrentEffect", value);
            return entity;
        }

        public static T SetRetargetActionType<T>(this T entity, ActionType value)
            where T : EffectDescription
        {
            entity.SetField("retargetActionType", value);
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

        public static T SetTargetSide<T>(this T entity, Side value)
            where T : EffectDescription
        {
            entity.SetField("targetSide", value);
            return entity;
        }

        public static T SetTargetType<T>(this T entity, TargetType value)
            where T : EffectDescription
        {
            entity.SetField("targetType", value);
            return entity;
        }

        public static T SetTrapRangeType<T>(this T entity, TrapRangeType value)
            where T : EffectDescription
        {
            entity.SetField("trapRangeType", value);
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
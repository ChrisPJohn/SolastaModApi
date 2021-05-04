using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public class EffectDescriptionBuilder
    {
        private readonly EffectDescription effect;

        public EffectDescriptionBuilder()
        {
            effect = new EffectDescription();

            EffectAdvancement effectAdvancement = new EffectAdvancement();
            effectAdvancement.SetField("incrementMultiplier", 1);
            effect.SetEffectAdvancement(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.SpellDefinitions.MagicWeapon.EffectDescription.EffectParticleParameters);
            effect.SetEffectParticleParameters(particleParams);
        }

        public EffectDescriptionBuilder SetCreatedByCharacter()
        {
            effect.SetField("createdByCharacter", true);
            return this;
        }

        public EffectDescriptionBuilder SetParticleEffectParams(EffectParticleParameters particleParameters)
        {
            effect.SetEffectParticleParameters(particleParameters);
            return this;
        }

        public EffectDescriptionBuilder SetEffectAIParamters(EffectAIParameters effectAIParameters)
        {
            effect.SetEffectAIParameters(effectAIParameters);
            return this;
        }

        public EffectDescriptionBuilder SetEffectAIParameters(float aoeScoreMultiplier, int cooldownForCaster, int cooldownForBattle, bool dynamicCooldown)
        {
            EffectAIParameters aiParams = new EffectAIParameters();
            aiParams.SetAoeScoreMultiplier(aoeScoreMultiplier);
            aiParams.SetCooldownForCaster(cooldownForCaster);
            aiParams.SetCooldownForBattle(cooldownForBattle);
            aiParams.SetDynamicCooldown(dynamicCooldown);
            effect.SetEffectAIParameters(aiParams);
            return this;
        }

        public EffectDescriptionBuilder SetEffectAdvancement(RuleDefinitions.EffectIncrementMethod effectIncrementMethod, int incrementMultiplier, int additionalTargetsPerIncrement,
            int additionalDicePerIncrement, int additionalSpellLevelPerIncrement, int additionalSummonsPerIncrement, int additionalHPPerIncrement, int additionalTempHPPerIncrement,
            int additionalTargetCellsPerIncrement, int additionalItemBonus, RuleDefinitions.AdvancementDuration alteredDuration)
        {
            EffectAdvancement effectAdvancement = new EffectAdvancement();
            effectAdvancement.SetField("effectIncrementMethod", effectIncrementMethod);
            effectAdvancement.SetField("incrementMultiplier", incrementMultiplier);
            effectAdvancement.SetField("additionalTargetsPerIncrement", additionalTargetsPerIncrement);
            effectAdvancement.SetField("additionalDicePerIncrement", additionalDicePerIncrement);
            effectAdvancement.SetField("additionalSpellLevelPerIncrement", additionalSpellLevelPerIncrement);
            effectAdvancement.SetField("additionalSummonsPerIncrement", additionalSummonsPerIncrement);
            effectAdvancement.SetField("additionalHPPerIncrement", additionalHPPerIncrement);
            effectAdvancement.SetField("additionalTempHPPerIncrement", additionalTempHPPerIncrement);
            effectAdvancement.SetField("additionalTargetCellsPerIncrement", additionalTargetCellsPerIncrement);
            effectAdvancement.SetField("additionalItemBonus", additionalItemBonus);
            effectAdvancement.SetField("alteredDuration", alteredDuration);
            effect.SetEffectAdvancement(effectAdvancement);
            return this;
        }

        public EffectDescriptionBuilder SetTargetingData(RuleDefinitions.Side targetSide, RuleDefinitions.RangeType rangeType, int rangeParameter, RuleDefinitions.TargetType targetType, int targetParameter, int targetParameter2, ActionDefinitions.ItemSelectionType itemSelectionType)
        {
            effect.SetTargetSide(targetSide);
            effect.SetRangeType(rangeType);
            effect.SetField("rangeParameter", rangeParameter);
            effect.SetTargetType(targetType);
            effect.SetField("targetParameter", targetParameter);
            effect.SetField("targetParameter2", targetParameter2);
            effect.SetItemSelectionType(itemSelectionType);
            return this;
        }

        public EffectDescriptionBuilder NoVisibilityRequiredToTarget()
        {

            effect.SetField("requiresVisibilityForPosition", false);
            return this;
        }

        public EffectDescriptionBuilder HalfDamageOnMiss()
        {
            effect.SetField("halfDamageOnAMiss", true);
            return this;
        }

        public EffectDescriptionBuilder OptionalAdditionalAlly()
        {
            effect.SetField("inviteOptionalAlly", true);
            return this;
        }

        public EffectDescriptionBuilder AddHitAffinity(string tag, RuleDefinitions.AdvantageType advantageType)
        {
            HitAffinityByTag hitAffinity = new HitAffinityByTag();

            hitAffinity.SetField("tag", tag);
            hitAffinity.SetField("advantageType", advantageType);
            effect.HitAffinitiesByTargetTag.Add(hitAffinity);
            return this;
        }

        public EffectDescriptionBuilder ExcludeCaster()
        {
            effect.SetField("targetExcludeCaster", true);
            return this;
        }

        public EffectDescriptionBuilder MustPlaceNotOnCharacter()
        {
            effect.SetField("canBePlacedOnCharacter", false);
            return this;
        }

        public EffectDescriptionBuilder SetTargetProximityData(bool requiresTargetProximity, int targetProximityDistance)
        {
            effect.SetField("requiresTargetProximity", requiresTargetProximity);
            effect.SetField("targetProximityDistance", targetProximityDistance);
            return this;
        }

        public EffectDescriptionBuilder SetTargetFiltering(RuleDefinitions.TargetFilteringMethod targetFilteringMethod, RuleDefinitions.TargetFilteringTag targetFilteringTag,
            int poolFilterDiceNumber, RuleDefinitions.DieType poolFilterDieType)
        {
            effect.SetTargetFilteringMethod(targetFilteringMethod);
            effect.SetTargetFilteringTag(targetFilteringTag);
            effect.SetField("poolFilterDiceNumber", poolFilterDiceNumber);
            effect.SetPoolFilterDieType(poolFilterDieType);
            return this;
        }

        public EffectDescriptionBuilder SetBorderData(RuleDefinitions.EmissiveBorder emissiveBorder, int emissiveParameter)
        {
            effect.SetEmissiveBorder(emissiveBorder);
            effect.SetField("emissiveParameter", emissiveParameter);
            return this;
        }

        public EffectDescriptionBuilder SetRecurrentEffect(RuleDefinitions.RecurrentEffect recurrentEffect)
        {
            effect.SetRecurrentEffect(recurrentEffect);
            return this;
        }

        public EffectDescriptionBuilder SetRetargetData(bool retargetAfterDeath, ActionDefinitions.ActionType retargetActionType)
        {
            effect.SetField("retargetAfterDeath", retargetAfterDeath);
            effect.SetRetargetActionType(retargetActionType);
            return this;
        }

        public EffectDescriptionBuilder SetTrapRange(RuleDefinitions.TrapRangeType trapRangeType)
        {
            effect.SetTrapRangeType(trapRangeType);
            return this;
        }

        public EffectDescriptionBuilder SetRequiredCondition(ConditionDefinition targetConditionAsset)
        {
            effect.SetTargetConditionAsset(targetConditionAsset);
            effect.SetField("targetConditionName", targetConditionAsset.Name);
            return this;
        }

        public EffectDescriptionBuilder SetDurationData(RuleDefinitions.DurationType durationType, int durationParameter, RuleDefinitions.TurnOccurenceType endOfEffect)
        {
            effect.SetDurationType(durationType);
            effect.SetField("durationParameter", durationParameter);
            effect.SetEndOfEffect(endOfEffect);
            return this;
        }

        public EffectDescriptionBuilder SetSavingThrowData(bool hasSavingThrow, bool disableSavingThrowOnAllies, string savingThrowAbility, bool ignoreCover,
            RuleDefinitions.EffectDifficultyClassComputation difficultyClassComputation, string savingThrowDifficultyAbility,
            int fixedSavingThrowDifficultyClass, bool advantageForEnemies, List<SaveAffinityBySenseDescription> savingThrowAffinitiesBySense)
        {
            effect.SetField("hasSavingThrow", hasSavingThrow);
            effect.SetField("disableSavingThrowOnAllies", disableSavingThrowOnAllies);
            effect.SetField("savingThrowAbility", savingThrowAbility);
            effect.SetField("ignoreCover", ignoreCover);
            effect.SetDifficultyClassComputation(difficultyClassComputation);
            effect.SetField("savingThrowDifficultyAbility", savingThrowDifficultyAbility);
            effect.SetField("fixedSavingThrowDifficultyClass", fixedSavingThrowDifficultyClass);
            effect.SetField("advantageForEnemies", advantageForEnemies);
            effect.SetField("savingThrowAffinitiesBySense", savingThrowAffinitiesBySense);
            return this;
        }

        public EffectDescriptionBuilder RequireShoveToHit()
        {
            effect.SetField("hasShoveRoll", true);
            return this;
        }

        public EffectDescriptionBuilder CanBeDispersed()
        {
            effect.SetField("canBeDispersed", true);
            return this;
        }

        public EffectDescriptionBuilder SetVelocity(int velocityCellsPerRound, RuleDefinitions.VelocityType velocityType)
        {
            effect.SetField("hasVelocity", true);
            effect.SetField("velocityCellsPerRound", velocityCellsPerRound);
            effect.SetVelocityType(velocityType);
            return this;
        }
        
        public EffectDescriptionBuilder AddRestrictedCreatureFamilies(CharacterFamilyDefinition family)
        {
            effect.RestrictedCreatureFamilies.Add(family.Name);
            return this;
        }

        public EffectDescriptionBuilder AddImmuneCreatureFamilies(CharacterFamilyDefinition family)
        {
            effect.ImmuneCreatureFamilies.Add(family.Name);
            return this;
        }

        public EffectDescriptionBuilder AddRestrictedCharacterSize(RuleDefinitions.CreatureSize size)
        {
            effect.RestrictedCharacterSizes.Add(size);
            return this;
        }

        public EffectDescriptionBuilder SetEffectPool(int effectPoolAmount)
        {
            effect.SetField("hasLimitedEffectPool", true);
            effect.SetField("effectPoolAmount", effectPoolAmount);
            return this;
        }

        public EffectDescriptionBuilder SetSpeed(RuleDefinitions.SpeedType speedType, float speedParameter)
        {
            effect.SetSpeedType(speedType);
            effect.SetSpeedParameter(speedParameter);
            return this;
        }

        public EffectDescriptionBuilder SetOffsetImpactTime(float offsetImpactTimeBasedOnDistanceFactor, float offsetImpactTimePerTarget)
        {
            effect.SetField("offsetImpactTimeBasedOnDistance", true);
            effect.SetOffsetImpactTimeBasedOnDistanceFactor(offsetImpactTimeBasedOnDistanceFactor);
            effect.SetOffsetImpactTimePerTarget(offsetImpactTimePerTarget);
            return this;
        }

        public EffectDescriptionBuilder AddEffectForm(EffectForm effectForm)
        {
            effect.EffectForms.Add(effectForm);
            return this;
        }

        public EffectDescription Build()
        {
            return effect;
        }
    }
}

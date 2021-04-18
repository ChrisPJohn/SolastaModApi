using HarmonyLib;
using System.Collections.Generic;

namespace SolastaModApi
{
    public class EffectDescriptionBuilder
    {
        EffectDescription effect;

        public EffectDescriptionBuilder()
        {
            effect = new EffectDescription();

            EffectAdvancement effectAdvancement = new EffectAdvancement();
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(1);
            Traverse.Create(effect).Field("effectAdvancement").SetValue(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.SpellDefinitions.MagicWeapon.EffectDescription.EffectParticleParameters);
            Traverse.Create(effect).Field("effectParticleParameters").SetValue(particleParams);
        }

        public void SetCreatedByCharacter()
        {
            Traverse.Create(effect).Field("createdByCharacter").SetValue(true);
        }

        public void SetParticleEffectParams(EffectParticleParameters particleParameters)
        {
            Traverse.Create(effect).Field("effectParticleParameters").SetValue(particleParameters);
        }

        public void SetEffectAIParamters(EffectAIParameters effectAIParameters)
        {
            Traverse.Create(effect).Field("effectAIParameters").SetValue(effectAIParameters);
        }

        public void SetEffectAIParameters(float aoeScoreMultiplier, int cooldownForCaster, int cooldownForBattle, bool dynamicCooldown)
        {
            EffectAIParameters aiParams = new EffectAIParameters();
            Traverse.Create(aiParams).Field("aoeScoreMultiplier").SetValue(aoeScoreMultiplier);
            Traverse.Create(aiParams).Field("cooldownForCaster").SetValue(cooldownForCaster);
            Traverse.Create(aiParams).Field("cooldownForBattle").SetValue(cooldownForBattle);
            Traverse.Create(aiParams).Field("dynamicCooldown").SetValue(dynamicCooldown);
            Traverse.Create(effect).Field("effectAIParameters").SetValue(aiParams);
        }

        public void SetEffectAdvancement(RuleDefinitions.EffectIncrementMethod effectIncrementMethod, int incrementMultiplier, int additionalTargetsPerIncrement,
            int additionalDicePerIncrement, int additionalSpellLevelPerIncrement, int additionalSummonsPerIncrement, int additionalHPPerIncrement, int additionalTempHPPerIncrement,
            int additionalTargetCellsPerIncrement, int additionalItemBonus, RuleDefinitions.AdvancementDuration alteredDuration)
        {
            EffectAdvancement effectAdvancement = new EffectAdvancement();

            Traverse.Create(effectAdvancement).Field("effectIncrementMethod").SetValue(effectIncrementMethod);
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(incrementMultiplier);
            Traverse.Create(effectAdvancement).Field("additionalTargetsPerIncrement").SetValue(additionalTargetsPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalDicePerIncrement").SetValue(additionalDicePerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalSpellLevelPerIncrement").SetValue(additionalSpellLevelPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalSummonsPerIncrement").SetValue(additionalSummonsPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalHPPerIncrement").SetValue(additionalHPPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalTempHPPerIncrement").SetValue(additionalTempHPPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalTargetCellsPerIncrement").SetValue(additionalTargetCellsPerIncrement);
            Traverse.Create(effectAdvancement).Field("additionalItemBonus").SetValue(additionalItemBonus);
            Traverse.Create(effectAdvancement).Field("alteredDuration").SetValue(alteredDuration);

            Traverse.Create(effect).Field("effectAdvancement").SetValue(effectAdvancement);
        }

        public void SetTargetingData(RuleDefinitions.Side targetSide, RuleDefinitions.RangeType rangeType, int rangeParameter, RuleDefinitions.TargetType targetType, int targetParameter, int targetParameter2, ActionDefinitions.ItemSelectionType itemSelectionType)
        {
            Traverse.Create(effect).Field("targetSide").SetValue(targetSide);
            Traverse.Create(effect).Field("rangeType").SetValue(rangeType);
            Traverse.Create(effect).Field("rangeParameter").SetValue(rangeParameter);
            Traverse.Create(effect).Field("targetType").SetValue(targetType);
            Traverse.Create(effect).Field("targetParameter").SetValue(targetParameter);
            Traverse.Create(effect).Field("targetParameter2").SetValue(targetParameter2);
            Traverse.Create(effect).Field("itemSelectionType").SetValue(itemSelectionType);
        }

        public void NoVisibilityRequiredToTarget()
        {
            Traverse.Create(effect).Field("requiresVisibilityForPosition").SetValue(false);
        }

        public void HalfDamageOnMiss()
        {
            Traverse.Create(effect).Field("halfDamageOnAMiss").SetValue(true);
        }

        public void OptionalAdditionalAlly()
        {
            Traverse.Create(effect).Field("inviteOptionalAlly").SetValue(true);
        }

        public void AddHitAffinity(string tag, RuleDefinitions.AdvantageType advantageType)
        {
            HitAffinityByTag hitAffinity = new HitAffinityByTag();
            Traverse.Create(hitAffinity).Field("tag").SetValue(tag);
            Traverse.Create(hitAffinity).Field("advantageType").SetValue(advantageType);
            effect.HitAffinitiesByTargetTag.Add(hitAffinity);
        }

        public void ExcludeCaster()
        {
            Traverse.Create(effect).Field("targetExcludeCaster").SetValue(true);
        }

        public void MustPlaceNotOnCharacter()
        {
            Traverse.Create(effect).Field("canBePlacedOnCharacter").SetValue(false);
        }

        public void SetTargetProximityData(bool requiresTargetProximity, int targetProximityDistance)
        {
            Traverse.Create(effect).Field("requiresTargetProximity").SetValue(requiresTargetProximity);
            Traverse.Create(effect).Field("targetProximityDistance").SetValue(targetProximityDistance);
        }

        public void SetTargetFiltering(RuleDefinitions.TargetFilteringMethod targetFilteringMethod, RuleDefinitions.TargetFilteringTag targetFilteringTag,
            int poolFilterDiceNumber, RuleDefinitions.DieType poolFilterDieType)
        {
            Traverse.Create(effect).Field("targetFilteringMethod").SetValue(targetFilteringMethod);
            Traverse.Create(effect).Field("targetFilteringTag").SetValue(targetFilteringTag);
            Traverse.Create(effect).Field("poolFilterDiceNumber").SetValue(poolFilterDiceNumber);
            Traverse.Create(effect).Field("poolFilterDieType").SetValue(poolFilterDieType);
        }

        public void SetBorderData(RuleDefinitions.EmissiveBorder emissiveBorder, int emissiveParameter)
        {
            Traverse.Create(effect).Field("emissiveBorder").SetValue(emissiveBorder);
            Traverse.Create(effect).Field("emissiveParameter").SetValue(emissiveParameter);
        }

        public void SetRecurrentEffect(RuleDefinitions.RecurrentEffect recurrentEffect)
        {
            Traverse.Create(effect).Field("recurrentEffect").SetValue(recurrentEffect);
        }

        public void SetRetargetData(bool retargetAfterDeath, ActionDefinitions.ActionType retargetActionType)
        {
            Traverse.Create(effect).Field("retargetAfterDeath").SetValue(retargetAfterDeath);
            Traverse.Create(effect).Field("retargetActionType").SetValue(retargetActionType);
        }

        public void SetTrapRange(RuleDefinitions.TrapRangeType trapRangeType)
        {
            Traverse.Create(effect).Field("trapRangeType").SetValue(trapRangeType);
        }

        public void SetRequiredCondition(ConditionDefinition targetConditionAsset)
        {
            Traverse.Create(effect).Field("targetConditionAsset").SetValue(targetConditionAsset);
            Traverse.Create(effect).Field("targetConditionName").SetValue(targetConditionAsset.Name);
        }

        public void SetDurationData(RuleDefinitions.DurationType durationType, int durationParameter, RuleDefinitions.TurnOccurenceType endOfEffect)
        {
            Traverse.Create(effect).Field("durationType").SetValue(durationType);
            Traverse.Create(effect).Field("durationParameter").SetValue(durationParameter);
            Traverse.Create(effect).Field("endOfEffect").SetValue(endOfEffect);
        }

        public void SetSavingThrowData(bool hasSavingThrow, bool disableSavingThrowOnAllies, string savingThrowAbility, bool ignoreCover,
            RuleDefinitions.EffectDifficultyClassComputation difficultyClassComputation, string savingThrowDifficultyAbility,
            int fixedSavingThrowDifficultyClass, bool advantageForEnemies, List<SaveAffinityBySenseDescription> savingThrowAffinitiesBySense)
        {
            Traverse.Create(effect).Field("hasSavingThrow").SetValue(hasSavingThrow);
            Traverse.Create(effect).Field("disableSavingThrowOnAllies").SetValue(disableSavingThrowOnAllies);
            Traverse.Create(effect).Field("savingThrowAbility").SetValue(savingThrowAbility);
            Traverse.Create(effect).Field("ignoreCover").SetValue(ignoreCover);
            Traverse.Create(effect).Field("difficultyClassComputation").SetValue(difficultyClassComputation);
            Traverse.Create(effect).Field("savingThrowDifficultyAbility").SetValue(savingThrowDifficultyAbility);
            Traverse.Create(effect).Field("fixedSavingThrowDifficultyClass").SetValue(fixedSavingThrowDifficultyClass);
            Traverse.Create(effect).Field("advantageForEnemies").SetValue(advantageForEnemies);
            Traverse.Create(effect).Field("savingThrowAffinitiesBySense").SetValue(savingThrowAffinitiesBySense);
        }

        public void RequireShoveToHit()
        {
            Traverse.Create(effect).Field("hasShoveRoll").SetValue(true);
        }

        public void CanBeDispersed()
        {
            Traverse.Create(effect).Field("canBeDispersed").SetValue(true);
        }

        public void SetVelocity(int velocityCellsPerRound, RuleDefinitions.VelocityType velocityType)
        {
            Traverse.Create(effect).Field("hasVelocity").SetValue(true);
            Traverse.Create(effect).Field("velocityCellsPerRound").SetValue(velocityCellsPerRound);
            Traverse.Create(effect).Field("velocityType").SetValue(velocityType);
        }
        
        public void AddRestrictedCreatureFamilies(CharacterFamilyDefinition family)
        {
            effect.RestrictedCreatureFamilies.Add(family.Name);
        }

        public void AddImmuneCreatureFamilies(CharacterFamilyDefinition family)
        {
            effect.ImmuneCreatureFamilies.Add(family.Name);
        }

        public void AddRestrictedCharacterSize(RuleDefinitions.CreatureSize size)
        {
            effect.RestrictedCharacterSizes.Add(size);
        }

        public void SetEffectPool(int effectPoolAmount)
        {
            Traverse.Create(effect).Field("hasLimitedEffectPool").SetValue(true);
            Traverse.Create(effect).Field("effectPoolAmount").SetValue(effectPoolAmount);
        }

        public void SetSpeed(RuleDefinitions.SpeedType speedType, float speedParameter)
        {
            Traverse.Create(effect).Field("speedType").SetValue(speedType);
            Traverse.Create(effect).Field("speedParameter").SetValue(speedParameter);
        }

        public void SetOffsetImpactTime(float offsetImpactTimeBasedOnDistanceFactor, float offsetImpactTimePerTarget)
        {
            Traverse.Create(effect).Field("offsetImpactTimeBasedOnDistance").SetValue(true);
            Traverse.Create(effect).Field("offsetImpactTimeBasedOnDistanceFactor").SetValue(offsetImpactTimeBasedOnDistanceFactor);
            Traverse.Create(effect).Field("offsetImpactTimePerTarget").SetValue(offsetImpactTimePerTarget);
        }

        public void AddEffectForm(EffectForm effectForm)
        {
            effect.EffectForms.Add(effectForm);
        }

        public EffectDescription Build()
        {
            return effect;
        }
    }
}

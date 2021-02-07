using HarmonyLib;
using System.Collections.Generic;
using TA.AI;

namespace SolastaModApi
{
    class EffectDescriptionBuilder
    {
        EffectDescription MyEffect;

        public EffectDescriptionBuilder()
        {
            MyEffect = new EffectDescription();

            Traverse.Create(MyEffect).Field("createdByCharacter").SetValue(true);

            EffectAdvancement effectAdvancement = new EffectAdvancement();
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(1);
            Traverse.Create(MyEffect).Field("effectAdvancement").SetValue(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.SpellDefinitions.MagicWeapon.EffectDescription.EffectParticleParameters);
            Traverse.Create(MyEffect).Field("effectParticleParameters").SetValue(particleParams);
        }

        public void SetParticleEffectParams(EffectParticleParameters particleParameters)
        {
            Traverse.Create(MyEffect).Field("effectParticleParameters").SetValue(particleParameters);
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

            Traverse.Create(MyEffect).Field("effectAdvancement").SetValue(effectAdvancement);
        }

        public void SetTargetingData(RuleDefinitions.Side targetSide, RuleDefinitions.RangeType rangeType, int rangeParameter, RuleDefinitions.TargetType targetType, int targetParameter, int targetParameter2, ActionDefinitions.ItemSelectionType itemSelectionType)
        {
            Traverse.Create(MyEffect).Field("targetSide").SetValue(targetSide);
            Traverse.Create(MyEffect).Field("createdByCharacter").SetValue(true);
            Traverse.Create(MyEffect).Field("rangeType").SetValue(rangeType);
            Traverse.Create(MyEffect).Field("rangeParameter").SetValue(rangeParameter);
            Traverse.Create(MyEffect).Field("targetType").SetValue(targetType);
            Traverse.Create(MyEffect).Field("targetParameter").SetValue(targetParameter);
            Traverse.Create(MyEffect).Field("targetParameter2").SetValue(targetParameter2);
            Traverse.Create(MyEffect).Field("itemSelectionType").SetValue(itemSelectionType);
        }

        public void HalfDamageOnMiss()
        {
            Traverse.Create(MyEffect).Field("halfDamageOnAMiss").SetValue(true);
        }

        public void ExcludeCaster()
        {
            Traverse.Create(MyEffect).Field("targetExcludeCaster").SetValue(true);
        }

        public void MustPlaceNotOnCharacter()
        {
            Traverse.Create(MyEffect).Field("canBePlacedOnCharacter").SetValue(false);
        }

        public void SetTargetProximityData(bool requiresTargetProximity, int targetProximityDistance)
        {
            Traverse.Create(MyEffect).Field("requiresTargetProximity").SetValue(requiresTargetProximity);
            Traverse.Create(MyEffect).Field("targetProximityDistance").SetValue(targetProximityDistance);
        }

        public void SetTargetFiltering(RuleDefinitions.TargetFilteringMethod targetFilteringMethod, RuleDefinitions.TargetFilteringTag targetFilteringTag,
            int poolFilterDiceNumber, RuleDefinitions.DieType poolFilterDieType)
        {
            Traverse.Create(MyEffect).Field("targetFilteringMethod").SetValue(targetFilteringMethod);
            Traverse.Create(MyEffect).Field("targetFilteringTag").SetValue(targetFilteringTag);
            Traverse.Create(MyEffect).Field("poolFilterDiceNumber").SetValue(poolFilterDiceNumber);
            Traverse.Create(MyEffect).Field("poolFilterDieType").SetValue(poolFilterDieType);
        }

        public void SetBorderData(RuleDefinitions.EmissiveBorder emissiveBorder, int emissiveParameter)
        {
            Traverse.Create(MyEffect).Field("emissiveBorder").SetValue(emissiveBorder);
            Traverse.Create(MyEffect).Field("emissiveParameter").SetValue(emissiveParameter);
        }

        public void SetRecurrentEffect(RuleDefinitions.RecurrentEffect recurrentEffect)
        {
            Traverse.Create(MyEffect).Field("recurrentEffect").SetValue(recurrentEffect);
        }

        public void SetRetargetData(bool retargetAfterDeath, ActionDefinitions.ActionType retargetActionType)
        {
            Traverse.Create(MyEffect).Field("retargetAfterDeath").SetValue(retargetAfterDeath);
            Traverse.Create(MyEffect).Field("retargetActionType").SetValue(retargetActionType);
        }

        public void SetTrapRange(RuleDefinitions.TrapRangeType trapRangeType)
        {
            Traverse.Create(MyEffect).Field("trapRangeType").SetValue(trapRangeType);
        }

        public void SetRequiredCondition(ConditionDefinition targetConditionAsset)
        {
            Traverse.Create(MyEffect).Field("targetConditionAsset").SetValue(targetConditionAsset);
        }

        public void SetDurationData(RuleDefinitions.DurationType durationType, int durationParameter, RuleDefinitions.TurnOccurenceType endOfEffect)
        {
            Traverse.Create(MyEffect).Field("durationType").SetValue(durationType);
            Traverse.Create(MyEffect).Field("durationParameter").SetValue(durationParameter);
            Traverse.Create(MyEffect).Field("endOfEffect").SetValue(endOfEffect);
        }

        public void SetSavingThrowData(bool hasSavingThrow, bool disableSavingThrowOnAllies, string savingThrowAbility, bool ignoreCover,
            RuleDefinitions.EffectDifficultyClassComputation difficultyClassComputation, string savingThrowDifficultyAbility,
            int fixedSavingThrowDifficultyClass, bool advantageForEnemies, List<SaveAffinityBySenseDescription> savingThrowAffinitiesBySense)
        {
            Traverse.Create(MyEffect).Field("hasSavingThrow").SetValue(hasSavingThrow);
            Traverse.Create(MyEffect).Field("disableSavingThrowOnAllies").SetValue(disableSavingThrowOnAllies);
            Traverse.Create(MyEffect).Field("savingThrowAbility").SetValue(savingThrowAbility);
            Traverse.Create(MyEffect).Field("ignoreCover").SetValue(ignoreCover);
            Traverse.Create(MyEffect).Field("difficultyClassComputation").SetValue(difficultyClassComputation);
            Traverse.Create(MyEffect).Field("savingThrowDifficultyAbility").SetValue(savingThrowDifficultyAbility);
            Traverse.Create(MyEffect).Field("fixedSavingThrowDifficultyClass").SetValue(fixedSavingThrowDifficultyClass);
            Traverse.Create(MyEffect).Field("advantageForEnemies").SetValue(advantageForEnemies);
            Traverse.Create(MyEffect).Field("savingThrowAffinitiesBySense").SetValue(savingThrowAffinitiesBySense);
        }

        public void AddRestrictedCreatureFamilies(CharacterFamilyDefinition family)
        {
            MyEffect.RestrictedCreatureFamilies.Add(family.Name);
        }

        public void AddImmuneCreatureFamilies(CharacterFamilyDefinition family)
        {
            MyEffect.ImmuneCreatureFamilies.Add(family.Name);
        }

        public void AddConditionForm(ConditionDefinition condition)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Condition;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);

            ConditionForm conditionForm = new ConditionForm();
            Traverse.Create(conditionForm).Field("operation").SetValue(ConditionForm.ConditionOperation.Add);
            Traverse.Create(conditionForm).Field("conditionDefinition").SetValue(condition);
            Traverse.Create(conditionForm).Field("conditionDefinitionName").SetValue(condition.Name);

            Traverse.Create(effectForm).Field("conditionForm").SetValue(conditionForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddSpellForm()
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.SpellSlots;
            SpellSlotsForm spellSlotsForm = new SpellSlotsForm();
            Traverse.Create(spellSlotsForm).Field("type").SetValue(SpellSlotsForm.EffectType.RecoverHalfLevelUp);
            Traverse.Create(effectForm).Field("spellSlotsForm").SetValue(spellSlotsForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddMotionForm(MotionForm.MotionType motionType, int motionDistance)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Motion;
            MotionForm motionForm = new MotionForm();
            Traverse.Create(motionForm).Field("type").SetValue(motionType);
            Traverse.Create(motionForm).Field("distance").SetValue(motionDistance);
            Traverse.Create(effectForm).Field("motionForm").SetValue(motionForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddTempHPForm(EffectForm.LevelApplianceType applyLevel, RuleDefinitions.LevelSourceType levelType, bool applyAbilityBonus,
            int bonusHitPoints, RuleDefinitions.DieType dieType, int diceNumber)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.TemporaryHitPoints;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);
            Traverse.Create(effectForm).Field("applyLevel").SetValue(applyLevel);
            Traverse.Create(effectForm).Field("levelType").SetValue(levelType);
            Traverse.Create(effectForm).Field("applyAbilityBonus").SetValue(applyAbilityBonus);

            TemporaryHitPointsForm tempHPForm = new TemporaryHitPointsForm();
            tempHPForm.BonusHitPoints = bonusHitPoints;
            tempHPForm.DieType = dieType;
            tempHPForm.DiceNumber = diceNumber;

            Traverse.Create(effectForm).Field("temporaryHitPointsForm").SetValue(tempHPForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddHealingForm(EffectForm.LevelApplianceType applyLevel, RuleDefinitions.LevelSourceType levelType, bool applyAbilityBonus,
            int bonusHitPoints, RuleDefinitions.DieType dieType, int diceNumber)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Healing;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);
            Traverse.Create(effectForm).Field("applyLevel").SetValue(applyLevel);
            Traverse.Create(effectForm).Field("levelType").SetValue(levelType);
            Traverse.Create(effectForm).Field("applyAbilityBonus").SetValue(applyAbilityBonus);

            HealingForm healingForm = new HealingForm();
            healingForm.BonusHealing = bonusHitPoints;
            healingForm.DieType = dieType;
            healingForm.DiceNumber = diceNumber;

            Traverse.Create(effectForm).Field("healingForm").SetValue(healingForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddReviveForm(int secondsSinceDeath)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Revive;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);

            ReviveForm reviveForm = new ReviveForm();
            Traverse.Create(reviveForm).Field("maxSecondsSinceDeath").SetValue(secondsSinceDeath);

            Traverse.Create(effectForm).Field("reviveForm").SetValue(reviveForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddSummonForm(SummonForm.Type summonType, ItemDefinition item, int number, string monsterDefinitionName, ConditionDefinition conditionDefinition,
            bool persistOnConcentrationLoss, DecisionPackageDefinition decisionPackage, EffectProxyDefinition effectProxyDefinition)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Summon;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);

            SummonForm summonForm = new SummonForm();
            Traverse.Create(summonForm).Field("summonType").SetValue(summonType);
            Traverse.Create(summonForm).Field("itemDefinition").SetValue(item);
            Traverse.Create(summonForm).Field("number").SetValue(number);
            Traverse.Create(summonForm).Field("monsterDefinitionName").SetValue(monsterDefinitionName);
            Traverse.Create(summonForm).Field("conditionDefinition").SetValue(conditionDefinition);
            Traverse.Create(summonForm).Field("persistOnConcentrationLoss").SetValue(persistOnConcentrationLoss);
            Traverse.Create(summonForm).Field("decisionPackage").SetValue(decisionPackage);
            Traverse.Create(summonForm).Field("effectProxyDefinitionName").SetValue(effectProxyDefinition.Name);

            Traverse.Create(effectForm).Field("summonForm").SetValue(summonForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddDamageForm(EffectForm.LevelApplianceType applyLevel, RuleDefinitions.LevelSourceType levelType, bool applyAbilityBonus,
            string damageType, int bonusDamage, RuleDefinitions.DieType dieType, int diceNumber, bool hasSavingThrow, RuleDefinitions.EffectSavingThrowType savingThrowAffinity)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Damage;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);
            Traverse.Create(effectForm).Field("applyLevel").SetValue(applyLevel);
            Traverse.Create(effectForm).Field("levelType").SetValue(levelType);
            Traverse.Create(effectForm).Field("applyAbilityBonus").SetValue(applyAbilityBonus);
            Traverse.Create(effectForm).Field("hasSavingThrow").SetValue(hasSavingThrow);
            Traverse.Create(effectForm).Field("savingThrowAffinity").SetValue(savingThrowAffinity);


            DamageForm damageForm = new DamageForm();
            damageForm.BonusDamage = bonusDamage;
            damageForm.DamageType = damageType;
            damageForm.DiceNumber = diceNumber;
            damageForm.DieType = dieType;

            Traverse.Create(effectForm).Field("damageForm").SetValue(damageForm);
            MyEffect.EffectForms.Add(effectForm);
        }

        public void AddItemPropertyForm(List<FeatureUnlockByLevel> featureBySlotLevel, RuleDefinitions.ItemPropertyUsage usageLimitation, int useAmount)
        {
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.ItemProperty;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);

            ItemPropertyForm itemForm = new ItemPropertyForm();
            Traverse.Create(itemForm).Field("usageLimitation").SetValue(usageLimitation);
            Traverse.Create(itemForm).Field("useAmount").SetValue(useAmount);
            Traverse.Create(itemForm).Field("featureBySlotLevel").SetValue(featureBySlotLevel);

            Traverse.Create(effectForm).Field("itemPropertyForm").SetValue(itemForm);

            MyEffect.EffectForms.Add(effectForm);
        }

        public EffectDescription Build()
        {
            return MyEffect;
        }
    }
}

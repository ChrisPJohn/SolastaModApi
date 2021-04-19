using HarmonyLib;
using System.Collections.Generic;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.BuilderHelpers
{
    public class EffectFormBuilder
    {
        private readonly EffectForm effectForm;

        public EffectFormBuilder()
        {
            effectForm = new EffectForm();
        }

        public void HasSavingThrow(RuleDefinitions.EffectSavingThrowType savingThrowAffinity)
        {
            effectForm.HasSavingThrow = true;
            effectForm.SavingThrowAffinity = savingThrowAffinity;
        }

        public void CanSaveToCancel(RuleDefinitions.TurnOccurenceType saveOccurence)
        {
            effectForm.CanSaveToCancel = true;
            effectForm.SaveOccurence = saveOccurence;
        }

        public void CreatedByCharacter()
        {
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);
        }

        public void CreatedByCondition()
        {
            Traverse.Create(effectForm).Field("createdByCondition").SetValue(true);
        }

        public void ApplyAbilityBonus()
        {
            effectForm.ApplyAbilityBonus = true;
        }

        public void SetLevelAdvancement(EffectForm.LevelApplianceType applyLevel,
            RuleDefinitions.LevelSourceType levelType, int levelMultiplier)
        {
            Traverse.Create(effectForm).Field("applyLevel").SetValue(applyLevel);
            Traverse.Create(effectForm).Field("levelType").SetValue(levelType);
            Traverse.Create(effectForm).Field("levelMultiplier").SetValue(levelMultiplier);
        }

        public void SetAlterationForm(AlterationForm.Type alterationType)
        {
            effectForm.FormType = EffectForm.EffectFormType.Alteration;
            AlterationForm alterationForm= new AlterationForm();
            Traverse.Create(alterationForm).Field("alterationType").SetValue(alterationType);
            Traverse.Create(effectForm).Field("alterationForm").SetValue(alterationForm);
        }

        public void SetAlterationAbilityScore(string abilityScore, int valueIncrease, int maximumIncrease)
        {
            effectForm.FormType = EffectForm.EffectFormType.Alteration;
            AlterationForm alterationForm = new AlterationForm();
            Traverse.Create(alterationForm).Field("alterationType").SetValue(AlterationForm.Type.AbilityScoreIncrease);
            Traverse.Create(alterationForm).Field("abilityScore").SetValue(abilityScore);
            Traverse.Create(alterationForm).Field("valueIncrease").SetValue(valueIncrease);
            Traverse.Create(alterationForm).Field("maximumIncrease").SetValue(maximumIncrease);
            Traverse.Create(effectForm).Field("alterationForm").SetValue(alterationForm);
        }

        public void SetConditionForm(ConditionDefinition condition, ConditionForm.ConditionOperation operation, bool applyToSelf, bool forceOnSelf, List<ConditionDefinition> detrimentalConditions)
        {
            effectForm.FormType = EffectForm.EffectFormType.Condition;
            ConditionForm conditionForm = new ConditionForm();
            Traverse.Create(conditionForm).Field("operation").SetValue(operation);
            Traverse.Create(conditionForm).Field("conditionDefinition").SetValue(condition);
            Traverse.Create(conditionForm).Field("conditionDefinitionName").SetValue(condition.Name);
            Traverse.Create(conditionForm).Field("applyToSelf").SetValue(applyToSelf);
            Traverse.Create(conditionForm).Field("forceOnSelf").SetValue(forceOnSelf);
            Traverse.Create(conditionForm).Field("detrimentalConditions").SetValue(detrimentalConditions);
            Traverse.Create(effectForm).Field("conditionForm").SetValue(conditionForm);
        }

        public void SetCounterForm(CounterForm.CounterType type, int automaticSpellLevel, int checkBaseDC, bool addSpellCastingAbility, bool addProficiencyBonus)
        {
            effectForm.FormType = EffectForm.EffectFormType.Counter;
            CounterForm counterForm = new CounterForm();
            Traverse.Create(counterForm).Field("type").SetValue(type);
            Traverse.Create(counterForm).Field("automaticSpellLevel").SetValue(automaticSpellLevel);
            Traverse.Create(counterForm).Field("checkBaseDC").SetValue(checkBaseDC);
            Traverse.Create(counterForm).Field("addSpellCastingAbility").SetValue(addSpellCastingAbility);
            Traverse.Create(counterForm).Field("addProficiencyBonus").SetValue(addProficiencyBonus);
            Traverse.Create(effectForm).Field("counterForm").SetValue(counterForm);
        }

        public void SetDamageForm(bool versatile, RuleDefinitions.DieType versatileDieType, string damageType, int bonusDamage,
            RuleDefinitions.DieType dieType, int diceNumber, RuleDefinitions.HealFromInflictedDamage healFromInflictedDamage,
            List<RuleDefinitions.TrendInfo> damageBonusTrends)
        {
            effectForm.FormType = EffectForm.EffectFormType.Damage;
            DamageForm damageForm = new DamageForm();
            Traverse.Create(damageForm).Field("versatile").SetValue(versatile);
            damageForm.VersatileDieType = versatileDieType;
            damageForm.BonusDamage = bonusDamage;
            damageForm.DamageType = damageType;
            damageForm.DiceNumber = diceNumber;
            damageForm.DieType = dieType;
            Traverse.Create(damageForm).Field("healFromInflictedDamage").SetValue(healFromInflictedDamage);
            Traverse.Create(damageForm).Field("damageBonusTrends").SetValue(damageBonusTrends);
            Traverse.Create(effectForm).Field("damageForm").SetValue(damageForm);
        }

        public void SetDivinationForm(DivinationForm.Type divinationType, List<CharacterFamilyDefinition> creatureFamilies,
            List<string> revealedTags, int rangeCells)
        {
            effectForm.FormType = EffectForm.EffectFormType.Divination;
            DivinationForm divinationForm = new DivinationForm();
            Traverse.Create(divinationForm).Field("divinationType").SetValue(divinationType);
            Traverse.Create(divinationForm).Field("creatureFamilies").SetValue(creatureFamilies);
            Traverse.Create(divinationForm).Field("revealedTags").SetValue(revealedTags);
            Traverse.Create(divinationForm).Field("rangeCells").SetValue(rangeCells);
            Traverse.Create(effectForm).Field("divinationForm ").SetValue(divinationForm);
        }

        public void SetHealingForm(RuleDefinitions.HealingComputation healingComputation,
            int bonusHitPoints, RuleDefinitions.DieType dieType, int diceNumber, bool variablePool,
            RuleDefinitions.HealingCap healingCap)
        {
            effectForm.FormType = EffectForm.EffectFormType.Healing;
            
            HealingForm healingForm = new HealingForm();
            healingForm.HealingComputation = healingComputation;
            healingForm.BonusHealing = bonusHitPoints;
            healingForm.DieType = dieType;
            healingForm.DiceNumber = diceNumber;
            healingForm.VariablePool = variablePool;
            healingForm.HealingCap = healingCap;
            Traverse.Create(effectForm).Field("healingForm").SetValue(healingForm);
        }

        public void SetItemPropertyForm(List<FeatureUnlockByLevel> featureBySlotLevel, RuleDefinitions.ItemPropertyUsage usageLimitation, int useAmount)
        {
            effectForm.FormType = EffectForm.EffectFormType.ItemProperty;
            ItemPropertyForm itemForm = new ItemPropertyForm();
            Traverse.Create(itemForm).Field("usageLimitation").SetValue(usageLimitation);
            Traverse.Create(itemForm).Field("useAmount").SetValue(useAmount);
            Traverse.Create(itemForm).Field("featureBySlotLevel").SetValue(featureBySlotLevel);
            Traverse.Create(effectForm).Field("itemPropertyForm").SetValue(itemForm);
        }

        public void SetLightSourceForm(RuleDefinitions.LightSourceType lightSourceType, int brightRange, int dimAdditionalRange,
            Color color, AssetReference graphicsPrefabReference)
        {
            effectForm.FormType = EffectForm.EffectFormType.LightSource;
            LightSourceForm lightSourceForm = new LightSourceForm();
            Traverse.Create(lightSourceForm).Field("lightSourceType").SetValue(lightSourceType);
            Traverse.Create(lightSourceForm).Field("brightRange").SetValue(brightRange);
            Traverse.Create(lightSourceForm).Field("dimAdditionalRange").SetValue(dimAdditionalRange);
            Traverse.Create(lightSourceForm).Field("color").SetValue(color);
            Traverse.Create(lightSourceForm).Field("graphicsPrefabReference").SetValue(graphicsPrefabReference);
            Traverse.Create(effectForm).Field("lightSourceForm").SetValue(lightSourceForm);
        }

        public void SetMotionForm(MotionForm.MotionType motionType, int motionDistance)
        {
            effectForm.FormType = EffectForm.EffectFormType.Motion;
            MotionForm motionForm = new MotionForm();
            Traverse.Create(motionForm).Field("type").SetValue(motionType);
            Traverse.Create(motionForm).Field("distance").SetValue(motionDistance);
            Traverse.Create(effectForm).Field("motionForm").SetValue(motionForm);
        }

        public void SetReviveForm(int secondsSinceDeath, RuleDefinitions.ReviveHitPoints reviveHitPoints,
            List<ConditionDefinition> removedConditions)
        {
            effectForm.FormType = EffectForm.EffectFormType.Revive;
            ReviveForm reviveForm = new ReviveForm();
            Traverse.Create(reviveForm).Field("maxSecondsSinceDeath").SetValue(secondsSinceDeath);
            Traverse.Create(reviveForm).Field("reviveHitPoints").SetValue(reviveHitPoints);
            Traverse.Create(reviveForm).Field("removedConditions").SetValue(removedConditions);

            Traverse.Create(effectForm).Field("reviveForm").SetValue(reviveForm);
        }

        public void SetSpellForm(int maxSlotLevel)
        {
            effectForm.FormType = EffectForm.EffectFormType.SpellSlots;
            SpellSlotsForm spellSlotsForm = new SpellSlotsForm();
            Traverse.Create(spellSlotsForm).Field("type").SetValue(SpellSlotsForm.EffectType.RecoverHalfLevelUp);
            Traverse.Create(spellSlotsForm).Field("maxSlotLevel").SetValue(maxSlotLevel);
            Traverse.Create(effectForm).Field("spellSlotsForm").SetValue(spellSlotsForm);
        }

        public void SetSummonForm(SummonForm.Type summonType, ItemDefinition item, int number, string monsterDefinitionName, ConditionDefinition conditionDefinition,
            bool persistOnConcentrationLoss, DecisionPackageDefinition decisionPackage, EffectProxyDefinition effectProxyDefinition)
        {
            effectForm.FormType = EffectForm.EffectFormType.Summon;
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
        }

        public void SetTempHPForm(int bonusHitPoints, RuleDefinitions.DieType dieType, int diceNumber)
        {
            effectForm.FormType = EffectForm.EffectFormType.TemporaryHitPoints;
            TemporaryHitPointsForm tempHPForm = new TemporaryHitPointsForm();
            tempHPForm.BonusHitPoints = bonusHitPoints;
            tempHPForm.DieType = dieType;
            tempHPForm.DiceNumber = diceNumber;
            Traverse.Create(effectForm).Field("temporaryHitPointsForm").SetValue(tempHPForm);
        }

        public void SetTopologyForm(TopologyForm.Type changeType, bool impactsFlyingCharacters)
        {
            effectForm.FormType = EffectForm.EffectFormType.Topology;
            TopologyForm topologyForm = new TopologyForm();
            Traverse.Create(topologyForm).Field("changeType").SetValue(changeType);
            Traverse.Create(topologyForm).Field("impactsFlyingCharacters").SetValue(impactsFlyingCharacters);
            Traverse.Create(effectForm).Field("topologyForm").SetValue(topologyForm);
        }

        public EffectForm Build()
        {
            return effectForm;
        }
    }
}

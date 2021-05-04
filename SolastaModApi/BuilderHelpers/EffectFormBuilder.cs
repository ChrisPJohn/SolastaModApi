using HarmonyLib;
using System.Collections.Generic;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers
{
    public class EffectFormBuilder
    {
        private readonly EffectForm effectForm;

        public EffectFormBuilder()
        {
            effectForm = new EffectForm();
        }

        public EffectFormBuilder HasSavingThrow(RuleDefinitions.EffectSavingThrowType savingThrowAffinity)
        {
            effectForm.HasSavingThrow = true;
            effectForm.SavingThrowAffinity = savingThrowAffinity;
            return this;
        }

        public EffectFormBuilder CanSaveToCancel(RuleDefinitions.TurnOccurenceType saveOccurence)
        {
            effectForm.CanSaveToCancel = true;
            effectForm.SaveOccurence = saveOccurence;
            return this;
        }

        public EffectFormBuilder CreatedByCharacter()
        {
            effectForm.SetField("createdByCharacter", true);
            return this;
        }

        public EffectFormBuilder CreatedByCondition()
        {
            effectForm.SetField("createdByCondition", true);
            return this;
        }

        public EffectFormBuilder ApplyAbilityBonus()
        {
            effectForm.ApplyAbilityBonus = true;
            return this;
        }

        public EffectFormBuilder SetLevelAdvancement(EffectForm.LevelApplianceType applyLevel,
            RuleDefinitions.LevelSourceType levelType, int levelMultiplier)
        {
            effectForm.SetField("applyLevel", applyLevel);
            effectForm.SetField("levelType", levelType);
            effectForm.SetField("levelMultiplier", levelMultiplier);
            return this;
        }

        public EffectFormBuilder SetAlterationForm(AlterationForm.Type alterationType)
        {
            effectForm.FormType = EffectForm.EffectFormType.Alteration;
            AlterationForm alterationForm = new AlterationForm();
            alterationForm.SetField("alterationType", alterationType);
            effectForm.SetField("alterationForm", alterationForm);
            return this;
        }

        public EffectFormBuilder SetAlterationAbilityScore(string abilityScore, int valueIncrease, int maximumIncrease)
        {
            effectForm.FormType = EffectForm.EffectFormType.Alteration;
            AlterationForm alterationForm = new AlterationForm();
            alterationForm.SetField("alterationType", AlterationForm.Type.AbilityScoreIncrease);
            alterationForm.SetField("abilityScore", abilityScore);
            alterationForm.SetField("valueIncrease", valueIncrease);
            alterationForm.SetField("maximumIncrease", maximumIncrease);
            effectForm.SetField("alterationForm", alterationForm);
            return this;
        }

        public EffectFormBuilder SetConditionForm(ConditionDefinition condition, ConditionForm.ConditionOperation operation, bool applyToSelf, bool forceOnSelf, List<ConditionDefinition> detrimentalConditions)
        {
            effectForm.FormType = EffectForm.EffectFormType.Condition;
            ConditionForm conditionForm = new ConditionForm();
            conditionForm.SetField("operation", operation);
            conditionForm.SetField("conditionDefinition", condition);
            conditionForm.SetField("conditionDefinitionName", condition.Name);
            conditionForm.SetField("applyToSelf", applyToSelf);
            conditionForm.SetField("forceOnSelf", forceOnSelf);
            conditionForm.SetField("detrimentalConditions", detrimentalConditions);
            effectForm.SetField("conditionForm", conditionForm);
            return this;
        }

        public EffectFormBuilder SetCounterForm(CounterForm.CounterType type, int automaticSpellLevel, int checkBaseDC, bool addSpellCastingAbility, bool addProficiencyBonus)
        {
            effectForm.FormType = EffectForm.EffectFormType.Counter;
            CounterForm counterForm = new CounterForm();
            counterForm.SetField("type", type);
            counterForm.SetField("automaticSpellLevel", automaticSpellLevel);
            counterForm.SetField("checkBaseDC", checkBaseDC);
            counterForm.SetField("addSpellCastingAbility", addSpellCastingAbility);
            counterForm.SetField("addProficiencyBonus", addProficiencyBonus);
            effectForm.SetField("counterForm", counterForm);
            return this;
        }

        public EffectFormBuilder SetDamageForm(bool versatile, RuleDefinitions.DieType versatileDieType, string damageType, int bonusDamage,
            RuleDefinitions.DieType dieType, int diceNumber, RuleDefinitions.HealFromInflictedDamage healFromInflictedDamage,
            List<RuleDefinitions.TrendInfo> damageBonusTrends)
        {
            effectForm.FormType = EffectForm.EffectFormType.Damage;
            DamageForm damageForm = new DamageForm();
            damageForm.SetField("versatile", versatile);
            damageForm.VersatileDieType = versatileDieType;
            damageForm.BonusDamage = bonusDamage;
            damageForm.DamageType = damageType;
            damageForm.DiceNumber = diceNumber;
            damageForm.DieType = dieType;
            damageForm.SetField("healFromInflictedDamage", healFromInflictedDamage);
            damageForm.SetField("damageBonusTrends", damageBonusTrends);
            effectForm.SetField("damageForm", damageForm);
            return this;
        }

        public EffectFormBuilder SetDivinationForm(DivinationForm.Type divinationType, List<CharacterFamilyDefinition> creatureFamilies,
            List<string> revealedTags, int rangeCells)
        {
            effectForm.FormType = EffectForm.EffectFormType.Divination;
            DivinationForm divinationForm = new DivinationForm();
            divinationForm.SetField("divinationType", divinationType);
            divinationForm.SetField("creatureFamilies", creatureFamilies);
            divinationForm.SetField("revealedTags", revealedTags);
            divinationForm.SetField("rangeCells", rangeCells);
            effectForm.SetField("divinationForm ", divinationForm);
            return this;
        }

        public EffectFormBuilder SetHealingForm(RuleDefinitions.HealingComputation healingComputation,
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
            effectForm.SetField("healingForm", healingForm);
            return this;
        }

        public EffectFormBuilder SetItemPropertyForm(List<FeatureUnlockByLevel> featureBySlotLevel, RuleDefinitions.ItemPropertyUsage usageLimitation, int useAmount)
        {
            effectForm.FormType = EffectForm.EffectFormType.ItemProperty;
            ItemPropertyForm itemForm = new ItemPropertyForm();
            itemForm.SetField("usageLimitation", usageLimitation);
            itemForm.SetField("useAmount", useAmount);
            itemForm.SetField("featureBySlotLevel", featureBySlotLevel);
            effectForm.SetField("itemPropertyForm", itemForm);
            return this;
        }

        public EffectFormBuilder SetLightSourceForm(RuleDefinitions.LightSourceType lightSourceType, int brightRange, int dimAdditionalRange,
            Color color, AssetReference graphicsPrefabReference)
        {
            effectForm.FormType = EffectForm.EffectFormType.LightSource;
            LightSourceForm lightSourceForm = new LightSourceForm();
            lightSourceForm.SetField("lightSourceType", lightSourceType);
            lightSourceForm.SetField("brightRange", brightRange);
            lightSourceForm.SetField("dimAdditionalRange", dimAdditionalRange);
            lightSourceForm.SetField("color", color);
            lightSourceForm.SetField("graphicsPrefabReference", graphicsPrefabReference);
            effectForm.SetField("lightSourceForm", lightSourceForm);
            return this;
        }

        public EffectFormBuilder SetMotionForm(MotionForm.MotionType motionType, int motionDistance)
        {
            effectForm.FormType = EffectForm.EffectFormType.Motion;
            MotionForm motionForm = new MotionForm();
            motionForm.SetField("type", motionType);
            motionForm.SetField("distance", motionDistance);
            effectForm.SetField("motionForm", motionForm);
            return this;
        }

        public EffectFormBuilder SetReviveForm(int secondsSinceDeath, RuleDefinitions.ReviveHitPoints reviveHitPoints,
            List<ConditionDefinition> removedConditions)
        {
            effectForm.FormType = EffectForm.EffectFormType.Revive;
            ReviveForm reviveForm = new ReviveForm();
            reviveForm.SetField("maxSecondsSinceDeath", secondsSinceDeath);
            reviveForm.SetField("reviveHitPoints", reviveHitPoints);
            reviveForm.SetField("removedConditions", removedConditions);

            effectForm.SetField("reviveForm", reviveForm);
            return this;
        }

        public EffectFormBuilder SetSpellForm(int maxSlotLevel)
        {
            effectForm.FormType = EffectForm.EffectFormType.SpellSlots;
            SpellSlotsForm spellSlotsForm = new SpellSlotsForm();
            spellSlotsForm.SetField("type", SpellSlotsForm.EffectType.RecoverHalfLevelUp);
            spellSlotsForm.SetField("maxSlotLevel", maxSlotLevel);
            effectForm.SetField("spellSlotsForm", spellSlotsForm);
            return this;
        }

        public EffectFormBuilder SetSummonForm(SummonForm.Type summonType, ItemDefinition item, int number, string monsterDefinitionName, ConditionDefinition conditionDefinition,
            bool persistOnConcentrationLoss, DecisionPackageDefinition decisionPackage, EffectProxyDefinition effectProxyDefinition)
        {
            effectForm.FormType = EffectForm.EffectFormType.Summon;
            SummonForm summonForm = new SummonForm();
            summonForm.SetField("summonType", summonType);
            summonForm.SetField("itemDefinition", item);
            summonForm.SetField("number", number);
            summonForm.SetField("monsterDefinitionName", monsterDefinitionName);
            summonForm.SetField("conditionDefinition", conditionDefinition);
            summonForm.SetField("persistOnConcentrationLoss", persistOnConcentrationLoss);
            summonForm.SetField("decisionPackage", decisionPackage);
            summonForm.SetField("effectProxyDefinitionName", effectProxyDefinition.Name);
            effectForm.SetField("summonForm", summonForm);
            return this;
        }

        public EffectFormBuilder SetTempHPForm(int bonusHitPoints, RuleDefinitions.DieType dieType, int diceNumber)
        {
            effectForm.FormType = EffectForm.EffectFormType.TemporaryHitPoints;
            TemporaryHitPointsForm tempHPForm = new TemporaryHitPointsForm();
            tempHPForm.BonusHitPoints = bonusHitPoints;
            tempHPForm.DieType = dieType;
            tempHPForm.DiceNumber = diceNumber;
            effectForm.SetField("temporaryHitPointsForm", tempHPForm);
            return this;
        }

        public EffectFormBuilder SetTopologyForm(TopologyForm.Type changeType, bool impactsFlyingCharacters)
        {
            effectForm.FormType = EffectForm.EffectFormType.Topology;
            TopologyForm topologyForm = new TopologyForm();
            topologyForm.SetField("changeType", changeType);
            topologyForm.SetField("impactsFlyingCharacters", impactsFlyingCharacters);
            effectForm.SetField("topologyForm", topologyForm);
            return this;
        }

        public EffectForm Build()
        {
            return effectForm;
        }
    }
}

using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static FeatureDefinitionAttributeModifier;

namespace SolastaModApi
{
    class FeatureBuilder
    {
        public static FeatureDefinitionProficiency BuildProficiency(RuleDefinitions.ProficiencyType type,
            List<string> proficiencies, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionProficiency proficiency = ScriptableObject.CreateInstance<FeatureDefinitionProficiency>();
            Traverse.Create(proficiency).Field("proficiencyType").SetValue(type);
            foreach (string item in proficiencies)
            {
                proficiency.Proficiencies.Add(item);
            }
            Traverse.Create(proficiency).Field("name").SetValue(name);
            proficiency.name = name;
            Traverse.Create(proficiency).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(proficiency).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(proficiency);
            return proficiency;
        }

        public static FeatureDefinitionPointPool BuildPointPool(HeroDefinitions.PointsPoolType poolType, int poolAmount,
            List<string> choices, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPointPool pointPool = ScriptableObject.CreateInstance<FeatureDefinitionPointPool>();
            Traverse.Create(pointPool).Field("poolType").SetValue(poolType);
            Traverse.Create(pointPool).Field("poolAmount").SetValue(poolAmount);
            foreach (string item in choices)
            {
                pointPool.RestrictedChoices.Add(item);
            }
            Traverse.Create(pointPool).Field("name").SetValue(name);
            pointPool.name = name;
            Traverse.Create(pointPool).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(pointPool).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(pointPool);
            return pointPool;
        }

        public static FeatureDefinitionAttributeModifier BuildAttributeModifier(AttributeModifierOperation modifierType,
            string attribute, int amount, string name)
        {
            FeatureDefinitionAttributeModifier attributeMod = ScriptableObject.CreateInstance<FeatureDefinitionAttributeModifier>();
            Traverse.Create(attributeMod).Field("modifierType2").SetValue(modifierType);
            Traverse.Create(attributeMod).Field("modifiedAttribute").SetValue(attribute);
            Traverse.Create(attributeMod).Field("modifierValue").SetValue(amount);
            Traverse.Create(attributeMod).Field("name").SetValue(name);
            attributeMod.name = name;
            GuiPresentationBuilder guiBuilder = new GuiPresentationBuilder("Feature/&AttributeIncreaseDescription", "Feature/&AbilityScoreIncreaseTitle");
            Traverse.Create(attributeMod).Field("guiPresentation").SetValue(guiBuilder.Build());

            Traverse.Create(attributeMod).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(attributeMod);
            return attributeMod;
        }

        public static FeatureDefinitionAttributeModifier BuildAttributeModifier(AttributeModifierOperation modifierType,
            string attribute, int amount, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAttributeModifier attributeMod = ScriptableObject.CreateInstance<FeatureDefinitionAttributeModifier>();
            Traverse.Create(attributeMod).Field("modifierType2").SetValue(modifierType);
            Traverse.Create(attributeMod).Field("modifiedAttribute").SetValue(attribute);
            Traverse.Create(attributeMod).Field("modifierValue").SetValue(amount);
            Traverse.Create(attributeMod).Field("name").SetValue(name);
            attributeMod.name = name;
            Traverse.Create(attributeMod).Field("guiPresentation").SetValue(guiPresentation);

            Traverse.Create(attributeMod).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(attributeMod);
            return attributeMod;
        }

        public static FeatureDefinitionAttackModifier BuildAttackModifier(RuleDefinitions.AttackModifierMethod attackRollModifierMethod,
            int attackRollModifier, string attackRollAbilityScore, RuleDefinitions.AttackModifierMethod damageRollModifierMethod,
            int damageRollModifier, string damageRollAbilityScore, bool canAddAbilityBonusToSecondary, string additionalAttackTag,
            string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAttackModifier attackModifier = ScriptableObject.CreateInstance<FeatureDefinitionAttackModifier>();

            Traverse.Create(attackModifier).Field("attackRollModifierMethod").SetValue(attackRollModifierMethod);
            Traverse.Create(attackModifier).Field("attackRollModifier").SetValue(attackRollModifier);
            Traverse.Create(attackModifier).Field("attackRollAbilityScore").SetValue(attackRollAbilityScore);
            Traverse.Create(attackModifier).Field("damageRollModifierMethod").SetValue(damageRollModifierMethod);
            Traverse.Create(attackModifier).Field("damageRollModifier").SetValue(damageRollModifier);
            Traverse.Create(attackModifier).Field("damageRollAbilityScore").SetValue(damageRollAbilityScore);
            Traverse.Create(attackModifier).Field("canAddAbilityBonusToSecondary").SetValue(canAddAbilityBonusToSecondary);
            Traverse.Create(attackModifier).Field("additionalAttackTag").SetValue(additionalAttackTag);

            Traverse.Create(attackModifier).Field("name").SetValue(name);
            attackModifier.name = name;
            Traverse.Create(attackModifier).Field("guiPresentation").SetValue(guiPresentation);

            Traverse.Create(attackModifier).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(attackModifier);
            return attackModifier;
        }

        public static FeatureDefinitionSavingThrowAffinity BuildSavingThrowAffinity(List<string> abilityScores,
            RuleDefinitions.CharacterSavingThrowAffinity affinityType, bool againstMagic, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionSavingThrowAffinity savingAffinity = ScriptableObject.CreateInstance<FeatureDefinitionSavingThrowAffinity>();
            foreach (string ability in abilityScores)
            {
                FeatureDefinitionSavingThrowAffinity.SavingThrowAffinityGroup group = new FeatureDefinitionSavingThrowAffinity.SavingThrowAffinityGroup();
                group.abilityScoreName = ability;
                group.affinity = affinityType;
                if (againstMagic)
                {
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolAbjuration.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolConjuration.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolDivination.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolEnchantment.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolEvocation.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolIllusion.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolNecromancy.Name);
                    group.restrictedSchools.Add(DatabaseHelper.SchoolOfMagicDefinitions.SchoolTransmutation.Name);
                }
                savingAffinity.AffinityGroups.Add(group);
            }

            Traverse.Create(savingAffinity).Field("name").SetValue(name);
            savingAffinity.name = name;
            Traverse.Create(savingAffinity).Field("guiPresentation").SetValue(guiPresentation);

            Traverse.Create(savingAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(savingAffinity);
            return savingAffinity;
        }

        public static FeatureDefinitionAbilityCheckAffinity BuildAbilityAffinity(List<Tuple<string, string>> abilityProficiencyPairs,
            RuleDefinitions.CharacterAbilityCheckAffinity affinityType, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAbilityCheckAffinity abilityAffinity = ScriptableObject.CreateInstance<FeatureDefinitionAbilityCheckAffinity>();
            foreach (Tuple<string, string> abilityProficiency in abilityProficiencyPairs)
            {
                FeatureDefinitionAbilityCheckAffinity.AbilityCheckAffinityGroup group = new FeatureDefinitionAbilityCheckAffinity.AbilityCheckAffinityGroup();
                group.abilityScoreName = abilityProficiency.Item1;
                if (!String.IsNullOrEmpty(abilityProficiency.Item2))
                {
                    group.proficiencyName = abilityProficiency.Item2;
                }
                group.affinity = affinityType;
                abilityAffinity.AffinityGroups.Add(group);
            }

            Traverse.Create(abilityAffinity).Field("name").SetValue(name);
            abilityAffinity.name = name;
            Traverse.Create(abilityAffinity).Field("guiPresentation").SetValue(guiPresentation);

            Traverse.Create(abilityAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(abilityAffinity);
            return abilityAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityConcentration(RuleDefinitions.AdvantageType advantageType, int threshold, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("concentrationAdvantage").SetValue(advantageType);
            if (threshold > 0)
            {
                Traverse.Create(magicAffinity).Field("overConcentrationThreshold").SetValue(threshold);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinitySpecialtySpell(SpellDefinition spell, RuleDefinitions.AdvantageType advantageType, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("forcedSpellDefinition").SetValue(spell);
            Traverse.Create(magicAffinity).Field("forcedSavingThrowAffinity").SetValue(advantageType);

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityModifiers(int attackModifier, int dcModifier, int preparedModifier, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            if (attackModifier != 0)
            {
                Traverse.Create(magicAffinity).Field("spellAttackModifier").SetValue(attackModifier);
            }
            if (dcModifier != 0)
            {
                Traverse.Create(magicAffinity).Field("saveDCModifier").SetValue(dcModifier);
            }
            if (preparedModifier != 0)
            {
                Traverse.Create(magicAffinity).Field("maxPreparedSpellsModifier").SetValue(preparedModifier);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityScribing(float scribeDurationMultiplier, float scribeCostMultiplier,
            int additionalScribedSpells, RuleDefinitions.AdvantageType scribeAdvantage, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("scribeDurationMultiplier").SetValue(scribeDurationMultiplier);
            Traverse.Create(magicAffinity).Field("scribeCostMultiplier").SetValue(scribeCostMultiplier);
            Traverse.Create(magicAffinity).Field("additionalScribedSpells").SetValue(additionalScribedSpells);
            Traverse.Create(magicAffinity).Field("scribeAdvantageType").SetValue(scribeAdvantage);

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityHeightenedList(List<string> spellNames, int levelBonus, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("warListSlotBonus").SetValue(levelBonus);
            Traverse.Create(magicAffinity).Field("usesWarList").SetValue(true);
            foreach (string spell in spellNames)
            {
                magicAffinity.WarListSpells.Add(spell);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityRitualCasting(RuleDefinitions.RitualCasting ritualCasting, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("ritualCasting").SetValue(ritualCasting);

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityExtendedSpellList(SpellListDefinition spellListDefinition, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("extendedSpellList").SetValue(spellListDefinition);

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityImmunities(List<string> spellNames, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            foreach (string spell in spellNames)
            {
                magicAffinity.SpellImmunities.Add(spell);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityAutoIdentify(List<string> autoIdentify, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            foreach (string tag in autoIdentify)
            {
                magicAffinity.DeviceTagsAutoIdentifying.Add(tag);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        public static FeatureDefinitionPower BuildSpellFormPower(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
            RuleDefinitions.ActivationTime activationTime, int costPerUse, RuleDefinitions.RechargeRate recharge, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPower power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();

            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(usesPerRecharge);
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
            Traverse.Create(power).Field("rechargeRate").SetValue(recharge);

            EffectDescription effect = new EffectDescription();
            Traverse.Create(effect).Field("targetSide").SetValue(RuleDefinitions.Side.Ally);
            Traverse.Create(effect).Field("createdByCharacter").SetValue(true);
            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.SpellSlots;
            SpellSlotsForm spellSlotsForm = new SpellSlotsForm();
            Traverse.Create(spellSlotsForm).Field("type").SetValue(SpellSlotsForm.EffectType.RecoverHalfLevelUp);
            Traverse.Create(effectForm).Field("spellSlotsForm").SetValue(spellSlotsForm);
            effect.EffectForms.Add(effectForm);
            EffectAdvancement effectAdvancement = new EffectAdvancement();
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(1);
            Traverse.Create(effect).Field("effectAdvancement").SetValue(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.FeatureDefinitionPowers.PowerWizardArcaneRecovery.EffectDescription.EffectParticleParameters);
            Traverse.Create(effect).Field("effectParticleParameters").SetValue(particleParams);

            Traverse.Create(power).Field("effectDescription").SetValue(effect);

            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(power).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

        public static FeatureDefinitionPower BuildActionConditionPower(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
            string usesAbilityScoreName,
            RuleDefinitions.ActivationTime activationTime, int costPerUse, RuleDefinitions.RechargeRate recharge,
            RuleDefinitions.RangeType rangeType, int rangeParameter, RuleDefinitions.TargetType targetType,
            ActionDefinitions.ItemSelectionType itemSelectionType, RuleDefinitions.DurationType durationType, int durationParameter,
            RuleDefinitions.TurnOccurenceType endOfEffect, ConditionDefinition condition,
            string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPower power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();

            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(usesPerRecharge);
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
            Traverse.Create(power).Field("rechargeRate").SetValue(recharge);
            Traverse.Create(power).Field("usesAbilityScoreName").SetValue(usesAbilityScoreName);
            Traverse.Create(power).Field("uniqueInstance").SetValue(true);

            EffectDescription effect = new EffectDescription();
            Traverse.Create(effect).Field("targetSide").SetValue(RuleDefinitions.Side.Ally);
            Traverse.Create(effect).Field("createdByCharacter").SetValue(true);
            Traverse.Create(effect).Field("rangeType").SetValue(rangeType);
            Traverse.Create(effect).Field("rangeParameter").SetValue(rangeParameter);
            Traverse.Create(effect).Field("targetType").SetValue(targetType);
            Traverse.Create(effect).Field("itemSelectionType").SetValue(itemSelectionType);
            Traverse.Create(effect).Field("canBePlacedOnCharacter").SetValue(true);
            Traverse.Create(effect).Field("durationType").SetValue(durationType);
            Traverse.Create(effect).Field("durationParameter").SetValue(durationParameter);
            Traverse.Create(effect).Field("endOfEffect").SetValue(endOfEffect);

            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Condition;
            Traverse.Create(effectForm).Field("createdByCharacter").SetValue(true);

            ConditionForm conditionForm = new ConditionForm();
            Traverse.Create(conditionForm).Field("operation").SetValue(ConditionForm.ConditionOperation.Add);
            Traverse.Create(conditionForm).Field("conditionDefinition").SetValue(condition);
            Traverse.Create(conditionForm).Field("conditionDefinitionName").SetValue(condition.Name);

            Traverse.Create(effectForm).Field("conditionForm").SetValue(conditionForm);
            effect.EffectForms.Add(effectForm);

            EffectAdvancement effectAdvancement = new EffectAdvancement();
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(1);
            Traverse.Create(effect).Field("effectAdvancement").SetValue(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.SpellDefinitions.MagicWeapon.EffectDescription.EffectParticleParameters);
            Traverse.Create(effect).Field("effectParticleParameters").SetValue(particleParams);
            Traverse.Create(power).Field("effectDescription").SetValue(effect);

            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(power).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

        public static ConditionDefinition BuildCondition(List<FeatureDefinition> conditionFeatures, RuleDefinitions.DurationType durationType,
            int durationParameter, string name, GuiPresentation guiPresentation)
        {
            ConditionDefinition condition = ScriptableObject.CreateInstance<ConditionDefinition>();
            foreach (FeatureDefinition feature in conditionFeatures)
            {
                condition.Features.Add(feature);
            }
            Traverse.Create(condition).Field("conditionType").SetValue(RuleDefinitions.ConditionType.Beneficial);
            Traverse.Create(condition).Field("allowMultipleInstances").SetValue(false);
            Traverse.Create(condition).Field("durationType").SetValue(durationType);
            Traverse.Create(condition).Field("durationParameter").SetValue(durationParameter);
            AssetReference asset = new AssetReference();
            Traverse.Create(condition).Field("conditionStartParticleReference").SetValue(asset);
            Traverse.Create(condition).Field("conditionParticleReference").SetValue(asset);
            Traverse.Create(condition).Field("conditionEndParticleReference").SetValue(asset);
            Traverse.Create(condition).Field("characterShaderReference").SetValue(asset);
            Traverse.Create(condition).Field("recurrentEffectForms").SetValue(new List<EffectForm>());
            Traverse.Create(condition).Field("cancellingConditions").SetValue(new List<ConditionDefinition>());
            Traverse.Create(condition).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(condition).Field("name").SetValue(name);
            condition.name = name;
            Traverse.Create(condition).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<ConditionDefinition>().Add(condition);
            return condition;
        }

        public static FeatureDefinitionPower BuildMotionFormPower(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
            RuleDefinitions.ActivationTime activationTime, int costPerUse, RuleDefinitions.RechargeRate recharge,
            RuleDefinitions.RangeType rangeType, int rangeParameter, RuleDefinitions.TargetType targetType,
            RuleDefinitions.Side target, bool hasSavingThrow, bool disableSavingThrowOnAllies, string savingThrowAbility,
            RuleDefinitions.EffectDifficultyClassComputation difficultyClassComputation, string savingThrowDifficultyAbility,
            MotionForm.MotionType motionType, int motionDistance,
            int fixedSavingThrowDifficultyClass, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPower power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();

            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(usesPerRecharge);
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
            Traverse.Create(power).Field("rechargeRate").SetValue(recharge);

            EffectDescription effect = new EffectDescription();
            Traverse.Create(effect).Field("targetSide").SetValue(target);
            Traverse.Create(effect).Field("rangeType").SetValue(rangeType);
            Traverse.Create(effect).Field("rangeParameter").SetValue(rangeParameter);
            Traverse.Create(effect).Field("targetType").SetValue(targetType);
            Traverse.Create(effect).Field("createdByCharacter").SetValue(true);
            Traverse.Create(effect).Field("canBePlacedOnCharacter").SetValue(true);
            Traverse.Create(effect).Field("hasSavingThrow").SetValue(hasSavingThrow);
            Traverse.Create(effect).Field("disableSavingThrowOnAllies").SetValue(disableSavingThrowOnAllies);
            Traverse.Create(effect).Field("savingThrowAbility").SetValue(savingThrowAbility);
            Traverse.Create(effect).Field("difficultyClassComputation").SetValue(difficultyClassComputation);
            Traverse.Create(effect).Field("savingThrowDifficultyAbility").SetValue(savingThrowDifficultyAbility);
            Traverse.Create(effect).Field("fixedSavingThrowDifficultyClass").SetValue(fixedSavingThrowDifficultyClass);

            EffectForm effectForm = new EffectForm();
            effectForm.FormType = EffectForm.EffectFormType.Motion;
            MotionForm motionForm = new MotionForm();
            Traverse.Create(motionForm).Field("type").SetValue(motionType);
            Traverse.Create(motionForm).Field("distance").SetValue(motionDistance);
            Traverse.Create(effectForm).Field("motionForm").SetValue(motionForm);
            effect.EffectForms.Add(effectForm);
            EffectAdvancement effectAdvancement = new EffectAdvancement();
            Traverse.Create(effectAdvancement).Field("incrementMultiplier").SetValue(1);
            Traverse.Create(effect).Field("effectAdvancement").SetValue(effectAdvancement);

            EffectParticleParameters particleParams = new EffectParticleParameters(DatabaseHelper.FeatureDefinitionPowers.PowerWizardArcaneRecovery.EffectDescription.EffectParticleParameters);
            Traverse.Create(effect).Field("effectParticleParameters").SetValue(particleParams);

            Traverse.Create(power).Field("effectDescription").SetValue(effect);

            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(power).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

        public static FeatureDefinitionPower BuildPowerFromEffectDescription(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
            RuleDefinitions.ActivationTime activationTime, int costPerUse, RuleDefinitions.RechargeRate recharge,
            bool proficiencyBonusToAttack, bool abilityScoreBonusToAttack, string abilityScore,
            EffectDescription effectDescription, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPower power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();

            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(usesPerRecharge);
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
            Traverse.Create(power).Field("rechargeRate").SetValue(recharge);
            Traverse.Create(power).Field("proficiencyBonusToAttack").SetValue(proficiencyBonusToAttack);
            Traverse.Create(power).Field("abilityScoreBonusToAttack").SetValue(abilityScoreBonusToAttack);
            Traverse.Create(power).Field("abilityScore").SetValue(abilityScore);
            Traverse.Create(power).Field("usesAbilityScoreName").SetValue(abilityScore);

            Traverse.Create(power).Field("effectDescription").SetValue(effectDescription);

            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(power).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

        public static FeatureDefinitionPower BuildSpellPowerFromEffectDescription(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
            RuleDefinitions.ActivationTime activationTime, int costPerUse, RuleDefinitions.RechargeRate recharge, FeatureDefinitionCastSpell spellcastingFeature,
            bool proficiencyBonusToAttack, bool abilityScoreBonusToAttack, string abilityScore,
            EffectDescription effectDescription, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionPower power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();

            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(usesPerRecharge);
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
            Traverse.Create(power).Field("rechargeRate").SetValue(recharge);
            Traverse.Create(power).Field("spellcastingFeature").SetValue(spellcastingFeature);
            Traverse.Create(power).Field("proficiencyBonusToAttack").SetValue(proficiencyBonusToAttack);
            Traverse.Create(power).Field("abilityScoreBonusToAttack").SetValue(abilityScoreBonusToAttack);
            Traverse.Create(power).Field("abilityScore").SetValue(abilityScore);
            Traverse.Create(power).Field("usesAbilityScoreName").SetValue(abilityScore);

            Traverse.Create(power).Field("effectDescription").SetValue(effectDescription);

            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(power).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

        public static FeatureDefinitionBonusCantrips BuildBonusCantrips(List<SpellDefinition> cantrips, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionBonusCantrips bonusCantrips = ScriptableObject.CreateInstance<FeatureDefinitionBonusCantrips>();

            foreach (SpellDefinition cantrip in cantrips)
            {
                bonusCantrips.BonusCantrips.Add(cantrip);
            }

            Traverse.Create(bonusCantrips).Field("name").SetValue(name);
            bonusCantrips.name = name;
            Traverse.Create(bonusCantrips).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(bonusCantrips).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(bonusCantrips);
            return bonusCantrips;
        }

        public static FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup BuildAutoPreparedSpellGroup(int classLevel, List<SpellDefinition> spellnames)
        {
            FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup spellgroup = new FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup();
            Traverse.Create(spellgroup).Field("classLevel").SetValue(classLevel);
            Traverse.Create(spellgroup).Field("spellsList").SetValue(new List<SpellDefinition>());
            foreach (SpellDefinition spell in spellnames)
            {
                spellgroup.SpellsList.Add(spell);
            }
            return spellgroup;
        }

        public static FeatureDefinitionAutoPreparedSpells BuildAutoPreparedSpells(List<FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup> autospelllists,
            CharacterClassDefinition characterclass, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAutoPreparedSpells autopreparedspell = ScriptableObject.CreateInstance<FeatureDefinitionAutoPreparedSpells>();
            Traverse.Create(autopreparedspell).Field("autoPreparedSpellsGroups").SetValue(new List<FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup>());
            foreach (FeatureDefinitionAutoPreparedSpells.AutoPreparedSpellsGroup groups in autospelllists)
            {
                autopreparedspell.AutoPreparedSpellsGroups.Add(groups);
            }
            Traverse.Create(autopreparedspell).Field("spellcastingClass").SetValue(characterclass);
            Traverse.Create(autopreparedspell).Field("contentCopyright").SetValue(4);
            Traverse.Create(autopreparedspell).Field("name").SetValue(name);
            autopreparedspell.name = name;
            Traverse.Create(autopreparedspell).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(autopreparedspell).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(autopreparedspell);
            return autopreparedspell;
        }

        public static FeatureDefinitionDieRollModifier BuildDieRollModifier(RuleDefinitions.RollContext context, int rerollCount, int minRerollValue, string consoleLocalizationKey, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionDieRollModifier dieRollModifier = ScriptableObject.CreateInstance<FeatureDefinitionDieRollModifier>();
            Traverse.Create(dieRollModifier).Field("validityContext").SetValue(context);
            Traverse.Create(dieRollModifier).Field("rerollLocalizationKey").SetValue(consoleLocalizationKey);
            Traverse.Create(dieRollModifier).Field("rerollCount").SetValue(rerollCount);
            Traverse.Create(dieRollModifier).Field("minRerollValue").SetValue(minRerollValue);
            Traverse.Create(dieRollModifier).Field("name").SetValue(name);
            dieRollModifier.name = name;
            Traverse.Create(dieRollModifier).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(dieRollModifier).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(dieRollModifier);
            return dieRollModifier;
        }

        public static FeatureDefinitionAdditionalDamage BuildAdditionalDamage(string notificationTag, RuleDefinitions.FeatureLimitedUsage limitedUsage,
            RuleDefinitions.AdditionalDamageValueDetermination damageValueDetermination,
            RuleDefinitions.AdditionalDamageTriggerCondition triggerCondition, RuleDefinitions.AdditionalDamageRequiredProperty requiredProperty,
            bool attackModeOnly, RuleDefinitions.DieType damageDieType, int damageDiceNumber, RuleDefinitions.AdditionalDamageType additionalDamageType,
            string specificDamageType, RuleDefinitions.AdditionalDamageAdvancement damageAdvancement, List<DiceByRank> diceByRankTable,
            string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAdditionalDamage additionalDamage = ScriptableObject.CreateInstance<FeatureDefinitionAdditionalDamage>();
            Traverse.Create(additionalDamage).Field("notificationTag").SetValue(notificationTag);
            Traverse.Create(additionalDamage).Field("limitedUsage").SetValue(limitedUsage);
            Traverse.Create(additionalDamage).Field("damageValueDetermination").SetValue(damageValueDetermination);
            Traverse.Create(additionalDamage).Field("triggerCondition").SetValue(triggerCondition);
            Traverse.Create(additionalDamage).Field("requiredProperty").SetValue(requiredProperty);
            Traverse.Create(additionalDamage).Field("attackModeOnly").SetValue(attackModeOnly);
            Traverse.Create(additionalDamage).Field("damageDieType").SetValue(damageDieType);
            Traverse.Create(additionalDamage).Field("damageDiceNumber").SetValue(damageDiceNumber);
            Traverse.Create(additionalDamage).Field("additionalDamageType").SetValue(additionalDamageType);
            Traverse.Create(additionalDamage).Field("specificDamageType").SetValue(specificDamageType);
            Traverse.Create(additionalDamage).Field("damageAdvancement").SetValue(damageAdvancement);
            Traverse.Create(additionalDamage).Field("diceByRankTable").SetValue(diceByRankTable);
            Traverse.Create(additionalDamage).Field("damageDieType").SetValue(damageDieType);
            Traverse.Create(additionalDamage).Field("conditionOperations").SetValue(new List<ConditionOperationDescription>());

            Traverse.Create(additionalDamage).Field("name").SetValue(name);
            additionalDamage.name = name;
            Traverse.Create(additionalDamage).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(additionalDamage).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(additionalDamage);
            return additionalDamage;
        }

        public static FeatureDefinitionAdditionalDamage BuildAdditionalDamage(string notificationTag, RuleDefinitions.FeatureLimitedUsage limitedUsage,
            RuleDefinitions.AdditionalDamageValueDetermination damageValueDetermination,
            RuleDefinitions.AdditionalDamageTriggerCondition triggerCondition, RuleDefinitions.AdditionalDamageRequiredProperty requiredProperty,
            bool attackModeOnly, RuleDefinitions.DieType damageDieType, int damageDiceNumber, RuleDefinitions.AdditionalDamageType additionalDamageType,
            string specificDamageType, RuleDefinitions.AdditionalDamageAdvancement damageAdvancement, List<DiceByRank> diceByRankTable,
            bool hasSavingThrow, string savingThrowAbility, int savingThrowDC, RuleDefinitions.EffectSavingThrowType damageSaveAffinity,
            List<ConditionOperationDescription> conditionOperations,
            string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionAdditionalDamage additionalDamage = ScriptableObject.CreateInstance<FeatureDefinitionAdditionalDamage>();
            Traverse.Create(additionalDamage).Field("notificationTag").SetValue(notificationTag);
            Traverse.Create(additionalDamage).Field("limitedUsage").SetValue(limitedUsage);
            Traverse.Create(additionalDamage).Field("damageValueDetermination").SetValue(damageValueDetermination);
            Traverse.Create(additionalDamage).Field("triggerCondition").SetValue(triggerCondition);
            Traverse.Create(additionalDamage).Field("requiredProperty").SetValue(requiredProperty);
            Traverse.Create(additionalDamage).Field("attackModeOnly").SetValue(attackModeOnly);
            Traverse.Create(additionalDamage).Field("damageDieType").SetValue(damageDieType);
            Traverse.Create(additionalDamage).Field("damageDiceNumber").SetValue(damageDiceNumber);
            Traverse.Create(additionalDamage).Field("additionalDamageType").SetValue(additionalDamageType);
            Traverse.Create(additionalDamage).Field("specificDamageType").SetValue(specificDamageType);
            Traverse.Create(additionalDamage).Field("damageAdvancement").SetValue(damageAdvancement);
            Traverse.Create(additionalDamage).Field("diceByRankTable").SetValue(diceByRankTable);
            Traverse.Create(additionalDamage).Field("damageDieType").SetValue(damageDieType);

            Traverse.Create(additionalDamage).Field("hasSavingThrow").SetValue(hasSavingThrow);
            Traverse.Create(additionalDamage).Field("savingThrowAbility").SetValue(savingThrowAbility);
            Traverse.Create(additionalDamage).Field("savingThrowDC").SetValue(savingThrowDC);
            Traverse.Create(additionalDamage).Field("damageSaveAffinity").SetValue(damageSaveAffinity);
            Traverse.Create(additionalDamage).Field("conditionOperations").SetValue(conditionOperations);

            Traverse.Create(additionalDamage).Field("name").SetValue(name);
            additionalDamage.name = name;
            Traverse.Create(additionalDamage).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(additionalDamage).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(additionalDamage);
            return additionalDamage;
        }

        public static FeatureDefinitionHealingModifier BuildHealingModifier(int healingBonusDiceNumber, RuleDefinitions.DieType healingBonusDiceType,
            RuleDefinitions.LevelSourceType addLevel, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionHealingModifier healingModifier = ScriptableObject.CreateInstance<FeatureDefinitionHealingModifier>();
            Traverse.Create(healingModifier).Field("healingBonusDiceNumber").SetValue(healingBonusDiceNumber);
            Traverse.Create(healingModifier).Field("healingBonusDiceType").SetValue(healingBonusDiceType);
            Traverse.Create(healingModifier).Field("addLevel").SetValue(addLevel);

            Traverse.Create(healingModifier).Field("name").SetValue(name);
            healingModifier.name = name;
            Traverse.Create(healingModifier).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(healingModifier).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(healingModifier);
            return healingModifier;
        }

        public static FeatureDefinitionMovementAffinity BuildMovementAffinity(bool addBase, int speedAdd, float speedMult, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMovementAffinity movement = ScriptableObject.CreateInstance<FeatureDefinitionMovementAffinity>();
            Traverse.Create(movement).Field("appliesToAllModes").SetValue(true);
            Traverse.Create(movement).Field("baseSpeedMultiplicativeModifier").SetValue(speedMult);
            Traverse.Create(movement).Field("baseSpeedAdditiveModifier").SetValue(speedAdd);
            Traverse.Create(movement).Field("speedAddBase").SetValue(addBase);
            Traverse.Create(movement).Field("name").SetValue(name);
            movement.name = name;
            Traverse.Create(movement).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(movement).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(movement);
            return movement;
        }

        public static FeatureDefinitionEquipmentAffinity BuildEquipmentAffinity(float carryingCapacityMultiplier, float additionalCarryingCapacity, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionEquipmentAffinity equipmentAffinity = ScriptableObject.CreateInstance<FeatureDefinitionEquipmentAffinity>();
            Traverse.Create(equipmentAffinity).Field("carryingCapacityMultiplier").SetValue(carryingCapacityMultiplier);
            Traverse.Create(equipmentAffinity).Field("additionalCarryingCapacity").SetValue(additionalCarryingCapacity);
            Traverse.Create(equipmentAffinity).Field("name").SetValue(name);
            equipmentAffinity.name = name;
            Traverse.Create(equipmentAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(equipmentAffinity).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(equipmentAffinity);
            return equipmentAffinity;
        }
    }
}

using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;
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
            Traverse.Create(proficiency).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(pointPool).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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

            Traverse.Create(attributeMod).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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

            Traverse.Create(attributeMod).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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

            Traverse.Create(attackModifier).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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

            Traverse.Create(savingAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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

            Traverse.Create(abilityAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }

        // ????
        //public bool CanFailSpellcasting { get; }
        //public int SpellcastingSuccessDC { get; }

        public static FeatureDefinitionMagicAffinity BuildMagicAffinityHeightenedList(List<string> spellNames, int levelBonus, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionMagicAffinity magicAffinity = ScriptableObject.CreateInstance<FeatureDefinitionMagicAffinity>();

            Traverse.Create(magicAffinity).Field("warListSlotBonus").SetValue(levelBonus);
            Traverse.Create(magicAffinity).Field("UsesWarList").SetValue(true);
            foreach (string spell in spellNames)
            {
                magicAffinity.WarListSpells.Add(spell);
            }

            Traverse.Create(magicAffinity).Field("name").SetValue(name);
            magicAffinity.name = name;
            Traverse.Create(magicAffinity).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
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
            Traverse.Create(magicAffinity).Field("guid").SetValue(System.Guid.NewGuid().ToString());
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(magicAffinity);
            return magicAffinity;
        }
    }
}

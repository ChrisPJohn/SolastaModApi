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
    }
}

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    class FeatureBuilder
    {
        public static FeatureDefinitionProficiency BuildProficiency(RuleDefinitions.ProficiencyType type,
            List<string> proficiencies, string name, GuiPresentation guiPresentation)
        {
            FeatureDefinitionProficiency proficiency = ScriptableObject.CreateInstance<FeatureDefinitionProficiency>();
            Traverse.Create(proficiency).Field("proficiencyType").SetValue(type);
            foreach(string item in proficiencies)
            {
                proficiency.Proficiencies.Add(item);
            }
            Traverse.Create(proficiency).Field("name").SetValue(name);
            Traverse.Create(proficiency).Field("guiPresentation").SetValue(guiPresentation);
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
            Traverse.Create(pointPool).Field("guiPresentation").SetValue(guiPresentation);
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(pointPool);
            return pointPool;
        }
    }
}

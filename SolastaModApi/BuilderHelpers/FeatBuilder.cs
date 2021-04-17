
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    public class FeatBuilder
    {
        private readonly FeatDefinition feat;

        public FeatBuilder(List<FeatureDefinition> features, string name, GuiPresentation guiPresentation, string guid)
        {
            feat = ScriptableObject.CreateInstance<FeatDefinition>();
            Traverse.Create(feat).Field("knownFeatsPrerequisite").SetValue(new List<string>());
            Traverse.Create(feat).Field("compatibleRacesPrerequisite").SetValue(new List<string>());
            Traverse.Create(feat).Field("compatibleClassesPrerequisite").SetValue(new List<string>());

            Traverse.Create(feat).Field("features").SetValue(features);
            Traverse.Create(feat).Field("name").SetValue(name);
            feat.name = name;
            Traverse.Create(feat).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(feat).Field("guid").SetValue(guid);
        }

        public void AddAbilityScorePrereq(string abilityScore, int value)
        {
            Traverse.Create(feat).Field("minimalAbilityScorePrerequisite").SetValue(true);
            Traverse.Create(feat).Field("minimalAbilityScoreName").SetValue(abilityScore);
            Traverse.Create(feat).Field("minimalAbilityScoreValue").SetValue(value);
        }

        public void AddSpellcasterPrereq()
        {
            Traverse.Create(feat).Field("mustCastSpellsPrerequisite").SetValue(true);
        }

        public void AddClassPrereq(List<string> classes)
        {
            Traverse.Create(feat).Field("compatibleClassesPrerequisite").SetValue(classes);
        }

        public void AddRacePrereq(List<string> races)
        {
            Traverse.Create(feat).Field("compatibleRacesPrerequisite").SetValue(races);
        }

        public void AddFeatPrereq(List<string> feats)
        {
            Traverse.Create(feat).Field("knownFeatsPrerequisite").SetValue(feats);
        }

        public void AddArmorProficiencyPrereq(ArmorCategoryDefinition category)
        {
            Traverse.Create(feat).Field("armorProficiencyPrerequisite").SetValue(true);
            Traverse.Create(feat).Field("armorProficiencyCategory").SetValue(category.Name);
        }

        public FeatDefinition BuildFeat()
        {
            DatabaseRepository.GetDatabase<FeatDefinition>().Add(feat);
            return feat;
        }
    }
}

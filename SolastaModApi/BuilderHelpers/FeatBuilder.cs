
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    class FeatBuilder
    {
        private FeatDefinition Feat;
        public FeatBuilder(List<FeatureDefinition> features, string name, GuiPresentation guiPresentation)
        {
            Feat = ScriptableObject.CreateInstance<FeatDefinition>();
            Traverse.Create(Feat).Field("knownFeatsPrerequisite").SetValue(new List<string>());
            Traverse.Create(Feat).Field("compatibleRacesPrerequisite").SetValue(new List<string>());
            Traverse.Create(Feat).Field("compatibleClassesPrerequisite").SetValue(new List<string>());

            Traverse.Create(Feat).Field("features").SetValue(features);
            Traverse.Create(Feat).Field("name").SetValue(name);
            Feat.name = name;
            Traverse.Create(Feat).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(Feat).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
        }

        public void AddAbilityScorePrereq(string abilityScore, int value)
        {
            Traverse.Create(Feat).Field("minimalAbilityScorePrerequisite").SetValue(true);
            Traverse.Create(Feat).Field("minimalAbilityScoreName").SetValue(abilityScore);
            Traverse.Create(Feat).Field("minimalAbilityScoreValue").SetValue(value);
        }

        public void AddSpellcasterPrereq()
        {
            Traverse.Create(Feat).Field("mustCastSpellsPrerequisite").SetValue(true);
        }

        public void AddClassPrereq(List<string> classes)
        {
            Traverse.Create(Feat).Field("compatibleClassesPrerequisite").SetValue(classes);
        }

        public void AddRacePrereq(List<string> races)
        {
            Traverse.Create(Feat).Field("compatibleRacesPrerequisite").SetValue(races);
        }

        public void AddFeatPrereq(List<string> feats)
        {
            Traverse.Create(Feat).Field("knownFeatsPrerequisite").SetValue(feats);
        }
        public FeatDefinition BuildFeat()
        {
            DatabaseRepository.GetDatabase<FeatDefinition>().Add(Feat);
            return Feat;
        }
    }
}

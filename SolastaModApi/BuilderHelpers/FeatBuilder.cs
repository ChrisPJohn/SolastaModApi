using System;
using System.Collections.Generic;

namespace SolastaModApi
{
    [Obsolete("Use FeatDefinitionBuilder")]
    public class FeatBuilder : FeatDefinitionBuilder
    {
        public FeatBuilder(string name, string guid, List<FeatureDefinition> features, GuiPresentation guiPresentation) : base(name, guid, features, guiPresentation)
        {
        }

        public void AddAbilityScorePrereq(string abilityScore, int value) => SetAbilityScorePrerequisite(abilityScore, value);

        public void AddSpellcasterPrereq() => SetMustCastSpellsPrerequisite();

        public void AddClassPrereq(List<string> classes) => SetClassPrerequisite(classes);

        public void AddRacePrereq(List<string> races) => SetRacePrerequisite(races);

        public void AddFeatPrereq(List<string> feats) => SetFeatPrerequisite(feats);

        public void AddArmorProficiencyPrereq(ArmorCategoryDefinition category) => SetArmorProficiencyPrerequisite(category);

        public FeatDefinition BuildFeat() => AddToDB();
    }
}

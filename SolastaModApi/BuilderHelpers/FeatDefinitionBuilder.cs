using SolastaModApi.Extensions;
using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public class FeatDefinitionBuilder : BaseDefinitionBuilder<FeatDefinition>
    {
        private void InitializePrerequisiteCollectionFields()
        {
            Definition.SetField("knownFeatsPrerequisite", new List<string>());
            Definition.SetField("compatibleRacesPrerequisite", new List<string>());
            Definition.SetField("compatibleClassesPrerequisite", new List<string>());
        }

        public FeatDefinitionBuilder(string name, string guid, List<FeatureDefinition> features, GuiPresentation guiPresentation) : base(name, guid)
        {
            InitializePrerequisiteCollectionFields();

            Definition.SetField("features", features);
            Definition.SetGuiPresentation(guiPresentation);
        }

        public FeatDefinitionBuilder(string name, string guid) : base(name, guid)
        {
            InitializePrerequisiteCollectionFields();
        }

        public void SetAbilityScorePrerequisite(string abilityScore, int value)
        {
            Definition.SetMinimalAbilityScorePrerequisite(true);
            Definition.SetMinimalAbilityScoreName(abilityScore);
            Definition.SetMinimalAbilityScoreValue(value);
        }

        public void SetMustCastSpellsPrerequisite()
        {
            Definition.SetMustCastSpellsPrerequisite(true);
        }

        public void SetClassPrerequisite(List<string> classes)
        {
            Definition.CompatibleClassesPrerequisite.Clear();
            Definition.CompatibleClassesPrerequisite.AddRange(classes);
        }

        public void SetRacePrerequisite(List<string> races)
        {
            Definition.CompatibleRacesPrerequisite.Clear();
            Definition.CompatibleRacesPrerequisite.AddRange(races);
        }

        public void SetFeatPrerequisite(List<string> feats)
        {
            Definition.KnownFeatsPrerequisite.Clear();
            Definition.KnownFeatsPrerequisite.AddRange(feats);
        }

        public void SetArmorProficiencyPrerequisite(ArmorCategoryDefinition category)
        {
            Definition.SetArmorProficiencyPrerequisite(true);
            Definition.SetArmorProficiencyCategory(category.Name);
        }
    }
}

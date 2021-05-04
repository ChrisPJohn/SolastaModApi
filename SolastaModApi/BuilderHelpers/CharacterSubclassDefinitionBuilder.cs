using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi
{
    public class CharacterSubclassDefinitionBuilder : BaseDefinitionBuilder<CharacterSubclassDefinition>
    {
        public CharacterSubclassDefinitionBuilder(string name, string guid) : base(name, guid)
        {
        }

        public CharacterSubclassDefinitionBuilder(string name, Guid guidNamespace) : base(name, guidNamespace)
        {
        }

        public CharacterSubclassDefinitionBuilder SetGuiPresentation(GuiPresentation gui)
        {
            Definition.SetGuiPresentation(gui);
            return this;
        }

        public CharacterSubclassDefinitionBuilder AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            var personalityFlag = new PersonalityFlagOccurence();

            personalityFlag.SetWeight(weight);
            personalityFlag.SetPersonalityFlag(personalityType.Name);

            Definition.PersonalityFlagOccurences.Add(personalityFlag);
            return this;
        }

        public CharacterSubclassDefinitionBuilder AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            Definition.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
            return this;
        }
    }
}

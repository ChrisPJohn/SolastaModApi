using System;

namespace SolastaModApi
{
    public class FeatureDefinitionSubclassChoiceBuilder : BaseDefinitionBuilder<FeatureDefinitionSubclassChoice>
    {
        public FeatureDefinitionSubclassChoiceBuilder(string name, Guid guidNamespace) : base(name, guidNamespace)
        {
        }

        public FeatureDefinitionSubclassChoiceBuilder(string name, string guid) : base(name, guid)
        {
        }

        public FeatureDefinitionSubclassChoiceBuilder SetFilterByDeity(bool requireDeity)
        {
            Definition.SetFilterByDeity(requireDeity);
            return this;
        }

        public FeatureDefinitionSubclassChoiceBuilder SetSubclassSuffix(string subclassSuffix)
        {
            Definition.SetSubclassSuffix(subclassSuffix);
            return this;
        }

        public FeatureDefinitionSubclassChoiceBuilder SetGuiPresentation(GuiPresentation guiPresentation)
        {
            Definition.SetGuiPresentation(guiPresentation);
            return this;
        }
    }
}

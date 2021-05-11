using SolastaModApi.Extensions;
using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi
{
    public class SpellBuilder : BaseDefinitionBuilder<SpellDefinition>
    {
        public SpellBuilder(string name, string guid) : base(name, guid)
        {
            InitializeFields();
        }

        public SpellBuilder(string name, Guid guidNamespace) : base(name, guidNamespace)
        {
            InitializeFields();
        }

        private void InitializeFields()
        {
            Definition.SetImplemented(true);
        }


        public SpellBuilder SetSpellLevel(int spellLevel)
        {
            Definition.SetSpellLevel(spellLevel);
            return this;
        }

        public SpellBuilder SetSchoolOfMagic(SchoolOfMagicDefinition school)
        {
            Definition.SetSchoolOfMagic(school.Name);
            return this;
        }

        public SpellBuilder SetSubSpells(List<SpellDefinition> subspells)
        {
            Definition.SetSpellsBundle(true);
            Definition.SetField("subspellsList", subspells);
            return this;
        }

        public SpellBuilder SetCastingTime(RuleDefinitions.ActivationTime castingTime)
        {
            Definition.SetCastingTime(castingTime);
            return this;
        }

        public SpellBuilder SetRitualCasting(RuleDefinitions.ActivationTime ritualCastingTime)
        {
            Definition.SetRitual(true);
            Definition.SetRitualCastingTime(ritualCastingTime);
            return this;
        }

        public SpellBuilder SetConcentration()
        {
            Definition.SetRequiresConcentration(true);
            return this;
        }

        public SpellBuilder SetUnique()
        {
            Definition.SetUniqueInstance(true);
            return this;
        }

        public SpellBuilder SetVerboseComponent(bool verboseComponent)
        {
            Definition.SetVerboseComponent(verboseComponent);
            return this;
        }

        public SpellBuilder SetSomaticComponent(bool somaticComponent)
        {
            Definition.SetSomaticComponent(somaticComponent);
            return this;
        }

        public SpellBuilder SetMaterialComponent(RuleDefinitions.MaterialComponentType materialComponentType)
        {
            Definition.SetMaterialComponentType(materialComponentType);
            return this;
        }

        public SpellBuilder SetSpecificMaterialComponent(string specificMaterialComponentTag,
            int specificMaterialComponentCostGp, bool specificMaterialComponentConsumed)
        {
            Definition.SetMaterialComponentType(RuleDefinitions.MaterialComponentType.Specific);
            Definition.SetSpecificMaterialComponentTag(specificMaterialComponentTag);
            Definition.SetSpecificMaterialComponentCostGp(specificMaterialComponentCostGp);
            Definition.SetSpecificMaterialComponentConsumed(specificMaterialComponentConsumed);
            return this;
        }

        public SpellBuilder SetEffectDescription(EffectDescription effectDescription)
        {
            Definition.SetEffectDescription(effectDescription);
            return this;
        }

        public SpellBuilder SetAiParameters(SpellAIParameters aiParameters)
        {
            Definition.SetAiParameters(aiParameters);
            return this;
        }

        public SpellBuilder SetConcentrationAction(ActionDefinitions.ActionParameter concentrationAction)
        {
            Definition.SetConcentrationAction(concentrationAction);
            return this;
        }

        public SpellBuilder SetGuiPresentation(GuiPresentation gui)
        {
            Definition.SetGuiPresentation(gui);
            return this;
        }

    }
}

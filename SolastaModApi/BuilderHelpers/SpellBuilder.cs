using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
	public class SpellBuilder
	{
		private readonly SpellDefinition spell;

		public SpellBuilder()
        {
			spell = ScriptableObject.CreateInstance<SpellDefinition>();
			Traverse.Create(spell).Field("implemented").SetValue(true);
		}

		public void SetName(string name, string guid)
        {
			Traverse.Create(spell).Field("name").SetValue(name);
			spell.name = name;
			Traverse.Create(spell).Field("guid").SetValue(guid);
		}

		public void SetSpellLevel(int spellLevel)
        {
			Traverse.Create(spell).Field("spellLevel").SetValue(spellLevel);
		}

		public void SetSchoolOfMagic(SchoolOfMagicDefinition school)
        {
			Traverse.Create(spell).Field("schoolOfMagic").SetValue(school.Name);
		}

		public void SetSubspells(List<SpellDefinition> subspells)
        {
			Traverse.Create(spell).Field("spellsBundle").SetValue(true);
			Traverse.Create(spell).Field("subspellsList").SetValue(subspells);
		}

		public void SetCastingTime(RuleDefinitions.ActivationTime castingTime)
        {
			Traverse.Create(spell).Field("castingTime").SetValue(castingTime);
		}

		public void SetRitualCasting(RuleDefinitions.ActivationTime ritualCastingTime)
        {
			Traverse.Create(spell).Field("ritual").SetValue(true);
			Traverse.Create(spell).Field("ritualCastingTime").SetValue(ritualCastingTime);
		}

		public void SetConcetration()
        {
			Traverse.Create(spell).Field("requiresConcentration").SetValue(true);
		}

		public void SetUnique()
        {
			Traverse.Create(spell).Field("uniqueInstance").SetValue(true);
		}

		public void SetVerboseComponent(bool verboseComponent)
        {
			Traverse.Create(spell).Field("verboseComponent").SetValue(verboseComponent);
		}

		public void SetSomaticComponent(bool somaticComponent)
        {
			Traverse.Create(spell).Field("somaticComponent").SetValue(somaticComponent);
		}

		public void SetMaterialComponent(RuleDefinitions.MaterialComponentType materialComponentType)
        {
			Traverse.Create(spell).Field("materialComponentType").SetValue(materialComponentType);
		}

		public void SetSpecificMaterialComponent(string specificMaterialComponentTag,
			int specificMaterialComponentCostGp, bool specificMaterialComponentConsumed)
		{
			Traverse.Create(spell).Field("materialComponentType").SetValue(RuleDefinitions.MaterialComponentType.Specific);
			Traverse.Create(spell).Field("specificMaterialComponentTag").SetValue(specificMaterialComponentTag);
			Traverse.Create(spell).Field("specificMaterialComponentCostGp").SetValue(specificMaterialComponentCostGp);
			Traverse.Create(spell).Field("specificMaterialComponentConsumed").SetValue(specificMaterialComponentConsumed);
		}

		public void SetEffectDescription(EffectDescription effectDescription)
        {
			Traverse.Create(spell).Field("effectDescription").SetValue(effectDescription);
		}

		public void SetAiParameters(SpellAIParameters aiParameters)
		{
			Traverse.Create(spell).Field("aiParameters").SetValue(aiParameters);
		}

		public void SetConcentrationAction(ActionDefinitions.ActionParameter concentrationAction)
        {
			Traverse.Create(spell).Field("concentrationAction").SetValue(concentrationAction);
		}

		public void SetGuiPresentation(GuiPresentation gui)
		{
			Traverse.Create(spell).Field("guiPresentation").SetValue(gui);
		}

		public SpellDefinition Build()
		{
			DatabaseRepository.GetDatabase<SpellDefinition>().Add(spell);
			return spell;
		}
	}
}

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
	class SpellBuilder
	{
		public static SpellDefinition Build(bool spellsBundle, List<SpellDefinition> subspellsList, string schoolOfMagic,
			int spellLevel, bool ritual, bool uniqueInstance, RuleDefinitions.ActivationTime castingTime, RuleDefinitions.ActivationTime ritualCastingTime,
			bool requiresConcentration, EffectDescription effectDescription, SpellAIParameters aiParameters, ActionDefinitions.ActionParameter concentrationAction,
			bool verboseComponent, bool somaticComponent, RuleDefinitions.MaterialComponentType materialComponentType, string specificMaterialComponentTag,
			int specificMaterialComponentCostGp, bool specificMaterialComponentConsumed, string name, GuiPresentation guiPresentation)
		{
			SpellDefinition spell = ScriptableObject.CreateInstance<SpellDefinition>();
			Traverse.Create(spell).Field("spellsBundle").SetValue(spellsBundle);
			Traverse.Create(spell).Field("subspellsList").SetValue(subspellsList);
			Traverse.Create(spell).Field("implemented").SetValue(true);
			Traverse.Create(spell).Field("schoolOfMagic").SetValue(schoolOfMagic);
			Traverse.Create(spell).Field("spellLevel").SetValue(spellLevel);
			Traverse.Create(spell).Field("ritual").SetValue(ritual);
			Traverse.Create(spell).Field("uniqueInstance").SetValue(uniqueInstance);
			Traverse.Create(spell).Field("castingTime").SetValue(castingTime);
			Traverse.Create(spell).Field("ritualCastingTime").SetValue(ritualCastingTime);
			Traverse.Create(spell).Field("requiresConcentration").SetValue(requiresConcentration);
			Traverse.Create(spell).Field("effectDescription").SetValue(effectDescription);
			Traverse.Create(spell).Field("aiParameters").SetValue(aiParameters);
			Traverse.Create(spell).Field("concentrationAction").SetValue(concentrationAction);
			Traverse.Create(spell).Field("verboseComponent").SetValue(verboseComponent);
			Traverse.Create(spell).Field("somaticComponent").SetValue(somaticComponent);
			Traverse.Create(spell).Field("materialComponentType").SetValue(materialComponentType);
			Traverse.Create(spell).Field("specificMaterialComponentTag").SetValue(specificMaterialComponentTag);
			Traverse.Create(spell).Field("specificMaterialComponentCostGp").SetValue(specificMaterialComponentCostGp);
			Traverse.Create(spell).Field("specificMaterialComponentConsumed").SetValue(specificMaterialComponentConsumed);

			Traverse.Create(spell).Field("name").SetValue(name);
			spell.name = name;
			Traverse.Create(spell).Field("guiPresentation").SetValue(guiPresentation);
			Traverse.Create(spell).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
			DatabaseRepository.GetDatabase<SpellDefinition>().Add(spell);
			return spell;
		}
	}
}

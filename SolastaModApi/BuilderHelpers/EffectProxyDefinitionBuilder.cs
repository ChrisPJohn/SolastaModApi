

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
	public class EffectProxyDefinitionBuilder
	{
		EffectProxyDefinition effectProxy;

		public EffectProxyDefinitionBuilder()
        {
			effectProxy = ScriptableObject.CreateInstance<EffectProxyDefinition>();
			Traverse.Create(effectProxy).Field("additionalFeatures").SetValue(new List<FeatureDefinition>());
		}

		public void SetName(string name, string guid)
        {
			Traverse.Create(effectProxy).Field("name").SetValue(name);
			effectProxy.name = name;
			Traverse.Create(effectProxy).Field("guid").SetValue(guid);
		}

		public void SetGuiPresentation(GuiPresentation gui)
		{
			Traverse.Create(effectProxy).Field("guiPresentation").SetValue(gui);
		}

		public void SetAttack(bool canAttack, RuleDefinitions.ProxyAttackMethod attackMethod,
			RuleDefinitions.DieType damageDie, string damageType)
        {
			Traverse.Create(effectProxy).Field("canAttack").SetValue(canAttack);
			Traverse.Create(effectProxy).Field("attackMethod").SetValue(attackMethod);
			Traverse.Create(effectProxy).Field("damageDie").SetValue(damageDie);
			Traverse.Create(effectProxy).Field("damageType").SetValue(damageType);
		}

		public void SetLightSource(LightSourceForm lightSourceForm)
        {
			Traverse.Create(effectProxy).Field("addLightSource").SetValue(true);
			Traverse.Create(effectProxy).Field("lightSourceForm").SetValue(lightSourceForm);
		}

		public void SetPortrait(AssetReferenceSprite portraitSpriteReference)
        {
			Traverse.Create(effectProxy).Field("hasPortrait").SetValue(true);
			Traverse.Create(effectProxy).Field("portraitSpriteReference").SetValue(portraitSpriteReference);
		}

		public void AddAdditionalFeature(FeatureDefinition feature)
        {
			effectProxy.AdditionalFeatures.Add(feature);
        }

		public void SetShowWorldLocationFeedbacks()
        {
			Traverse.Create(effectProxy).Field("showWorldLocationFeedbacks").SetValue(true);
		}

		public void SetAttackParticle(AssetReference attackParticle)
        {
			Traverse.Create(effectProxy).Field("attackParticle").SetValue(attackParticle);
		}

		public void SetAttackImpactParticle(AssetReference attackImpactParticle)
		{
			Traverse.Create(effectProxy).Field("attackImpactParticle").SetValue(attackImpactParticle);
		}

		public void SetSoundEffectOnHitDescription(SoundEffectOnHitDescription soundEffectOnHitDescription)
		{
			Traverse.Create(effectProxy).Field("soundEffectOnHitDescription").SetValue(soundEffectOnHitDescription);
		}

		public void SetCanMove()
        {
			Traverse.Create(effectProxy).Field("canMove").SetValue(true);
		}

		public void SetImpactsPlacement()
		{
			Traverse.Create(effectProxy).Field("impactsPlacement").SetValue(true);
		}

		public void SetModelScale(float modelScale)
		{
			Traverse.Create(effectProxy).Field("modelScale").SetValue(modelScale);
		}

		public void SetPresentationInformation(bool hasPresentation, AssetReference prefabReference, bool isEmptyPresentation)
		{
			Traverse.Create(effectProxy).Field("hasPresentation").SetValue(hasPresentation);
			Traverse.Create(effectProxy).Field("prefabReference").SetValue(prefabReference);
			Traverse.Create(effectProxy).Field("isEmptyPresentation").SetValue(isEmptyPresentation);
		}

		public EffectProxyDefinition Build() { 
			DatabaseRepository.GetDatabase<EffectProxyDefinition>().Add(effectProxy);
			return effectProxy;
		}
	}
}

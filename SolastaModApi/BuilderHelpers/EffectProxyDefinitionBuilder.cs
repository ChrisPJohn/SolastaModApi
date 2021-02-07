

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
	class EffectProxyDefinitionBuilder
	{


		public static EffectProxyDefinition Build(bool canMove, bool canAttack, RuleDefinitions.ProxyAttackMethod attackMethod,
			RuleDefinitions.DieType damageDie, string damageType, List<FeatureDefinition> additionalFeatures, bool addLightSource,
			LightSourceForm lightSourceForm, bool hasPresentation, AssetReference prefabReference, bool isEmptyPresentation,
			float modelScale, bool showWorldLocationFeedbacks, bool hasPortrait,
			AssetReferenceSprite portraitSpriteReference, string name, GuiPresentation guiPresentation)
		{
			EffectProxyDefinition effectProxy = ScriptableObject.CreateInstance<EffectProxyDefinition>();
			Traverse.Create(effectProxy).Field("canMove").SetValue(canMove);
			Traverse.Create(effectProxy).Field("canAttack").SetValue(canAttack);
			Traverse.Create(effectProxy).Field("attackMethod").SetValue(attackMethod);
			Traverse.Create(effectProxy).Field("damageDie").SetValue(damageDie);
			Traverse.Create(effectProxy).Field("damageType").SetValue(damageType);
			Traverse.Create(effectProxy).Field("additionalFeatures").SetValue(additionalFeatures);
			Traverse.Create(effectProxy).Field("addLightSource").SetValue(addLightSource);
			Traverse.Create(effectProxy).Field("lightSourceForm").SetValue(lightSourceForm);
			Traverse.Create(effectProxy).Field("hasPresentation").SetValue(hasPresentation);
			Traverse.Create(effectProxy).Field("prefabReference").SetValue(prefabReference);
			Traverse.Create(effectProxy).Field("isEmptyPresentation").SetValue(isEmptyPresentation);
			Traverse.Create(effectProxy).Field("modelScale").SetValue(modelScale);
			Traverse.Create(effectProxy).Field("showWorldLocationFeedbacks").SetValue(showWorldLocationFeedbacks);
			Traverse.Create(effectProxy).Field("hasPortrait").SetValue(hasPortrait);
			Traverse.Create(effectProxy).Field("portraitSpriteReference").SetValue(portraitSpriteReference);

			Traverse.Create(effectProxy).Field("name").SetValue(name);
			effectProxy.name = name;
			Traverse.Create(effectProxy).Field("guiPresentation").SetValue(guiPresentation);
			Traverse.Create(effectProxy).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
			DatabaseRepository.GetDatabase<EffectProxyDefinition>().Add(effectProxy);
			return effectProxy;
		}
	}
}

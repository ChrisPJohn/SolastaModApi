using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GadgetFlowDescription))]
    public static partial class GadgetFlowDescriptionExtensions
    {
        public static T SetAlterationType<T>(this T entity, AlterationForm.Type value)
            where T : GadgetFlowDescription
        {
            entity.SetField("alterationType", value);
            return entity;
        }

        public static T SetBattleEventCounter<T>(this T entity, int value)
            where T : GadgetFlowDescription
        {
            entity.SetField("battleEventCounter", value);
            return entity;
        }

        public static T SetBattleEventMaxOccurences<T>(this T entity, int value)
            where T : GadgetFlowDescription
        {
            entity.SetField("battleEventMaxOccurences", value);
            return entity;
        }

        public static T SetBoolParameter1<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("boolParameter1", value);
            return entity;
        }

        public static T SetCharacterInteractionDefinition<T>(this T entity, CharacterInteractionDefinition value)
            where T : GadgetFlowDescription
        {
            entity.SetField("characterInteractionDefinition", value);
            return entity;
        }

        public static T SetDamageType<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("damageType", value);
            return entity;
        }

        public static T SetDescription<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("description", value);
            return entity;
        }

        public static T SetId<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("id", value);
            return entity;
        }

        public static T SetInteractionHighlight<T>(this T entity, GameObject value)
            where T : GadgetFlowDescription
        {
            entity.SetField("interactionHighlight", value);
            return entity;
        }

        public static T SetInteractor<T>(this T entity, WorldManipulationInteractor value)
            where T : GadgetFlowDescription
        {
            entity.SetField("interactor", value);
            return entity;
        }

        public static T SetInteractWithBoundCharacters<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("interactWithBoundCharacters", value);
            return entity;
        }

        public static T SetIntParameter1<T>(this T entity, int value)
            where T : GadgetFlowDescription
        {
            entity.SetField("intParameter1", value);
            return entity;
        }

        public static T SetListenerType<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("listenerType", value);
            return entity;
        }

        public static T SetMinPerceptionRange<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("minPerceptionRange", value);
            return entity;
        }

        public static T SetOrientation<T>(this T entity, LocationDefinitions.Orientation value)
            where T : GadgetFlowDescription
        {
            entity.SetField("orientation", value);
            return entity;
        }

        public static T SetOutcomeNumber<T>(this T entity, int value)
            where T : GadgetFlowDescription
        {
            entity.SetField("outcomeNumber", value);
            return entity;
        }

        public static T SetPosition<T>(this T entity, int3 value)
            where T : GadgetFlowDescription
        {
            entity.SetField("position", value);
            return entity;
        }

        public static T SetQuestName<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("questName", value);
            return entity;
        }

        public static T SetRadius<T>(this T entity, float value)
            where T : GadgetFlowDescription
        {
            entity.SetField("radius", value);
            return entity;
        }

        public static T SetReactToLocationEntered<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("reactToLocationEntered", value);
            return entity;
        }

        public static T SetRevealedTag<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("revealedTag", value);
            return entity;
        }

        public static T SetSortAbilityScoreName<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("sortAbilityScoreName", value);
            return entity;
        }

        public static T SetSortByAbilityScore<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("sortByAbilityScore", value);
            return entity;
        }

        public static T SetSortProficiencyName<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("sortProficiencyName", value);
            return entity;
        }

        public static T SetSpecificEntrance<T>(this T entity, bool value)
            where T : GadgetFlowDescription
        {
            entity.SetField("specificEntrance", value);
            return entity;
        }

        public static T SetStepName<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("stepName", value);
            return entity;
        }

        public static T SetToggledCondition<T>(this T entity, GadgetDefinitions.ConditionConstrainedState value)
            where T : GadgetFlowDescription
        {
            entity.SetField("toggledCondition", value);
            return entity;
        }

        public static T SetVariableInteractionDefinitionParameter1<T>(this T entity, GadgetDefinitions.GadgetVariableScriptableObjectInteractionDefinition value)
            where T : GadgetFlowDescription
        {
            entity.SetField("variableInteractionDefinitionParameter1", value);
            return entity;
        }

        public static T SetVariableIntParameter1<T>(this T entity, GadgetDefinitions.GadgetVariableInt value)
            where T : GadgetFlowDescription
        {
            entity.SetField("variableIntParameter1", value);
            return entity;
        }

        public static T SetVariableName<T>(this T entity, string value)
            where T : GadgetFlowDescription
        {
            entity.SetField("variableName", value);
            return entity;
        }

        public static T SetVariableTestDescription<T>(this T entity, VariableTestDescription value)
            where T : GadgetFlowDescription
        {
            entity.SetField("variableTestDescription", value);
            return entity;
        }

        public static T SetVariableType<T>(this T entity, GameVariableDefinitions.Type value)
            where T : GadgetFlowDescription
        {
            entity.SetField("variableType", value);
            return entity;
        }

        public static T SetVolumetricTriggerMode<T>(this T entity, GadgetDefinitions.VolumetricTriggerMode value)
            where T : GadgetFlowDescription
        {
            entity.SetField("volumetricTriggerMode", value);
            return entity;
        }

        public static T SetWantedBattleEvent<T>(this T entity, GadgetDefinitions.BattleEvent value)
            where T : GadgetFlowDescription
        {
            entity.SetField("wantedBattleEvent", value);
            return entity;
        }

        public static T SetWantedContentPack<T>(this T entity, GamingPlatformDefinitions.ContentPack value)
            where T : GadgetFlowDescription
        {
            entity.SetField("wantedContentPack", value);
            return entity;
        }

        public static T SetWantedPresence<T>(this T entity, GadgetDefinitions.WantedPresence value)
            where T : GadgetFlowDescription
        {
            entity.SetField("wantedPresence", value);
            return entity;
        }

        public static T SetWantedPressure<T>(this T entity, GadgetDefinitions.WantedPressure value)
            where T : GadgetFlowDescription
        {
            entity.SetField("wantedPressure", value);
            return entity;
        }

        public static T SetWantedQuestUpdate<T>(this T entity, GadgetDefinitions.QuestUpdateType value)
            where T : GadgetFlowDescription
        {
            entity.SetField("wantedQuestUpdate", value);
            return entity;
        }
    }
}
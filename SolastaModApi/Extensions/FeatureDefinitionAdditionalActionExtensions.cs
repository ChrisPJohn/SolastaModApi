using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class FeatureDefinitionAdditionalActionExtensions
    {
        public static T SetActionType<T>(this T entity, ActionType value)
            where T : FeatureDefinitionAdditionalAction
        {
            entity.SetField("actionType", value);
            return entity;
        }

        public static T SetMaxAttacksNumber<T>(this T entity, int value)
            where T : FeatureDefinitionAdditionalAction
        {
            entity.SetField("maxAttacksNumber", value);
            return entity;
        }

        public static T SetTriggerCondition<T>(this T entity, AdditionalActionTriggerCondition value)
            where T : FeatureDefinitionAdditionalAction
        {
            entity.SetField("triggerCondition", value);
            return entity;
        }
    }
}
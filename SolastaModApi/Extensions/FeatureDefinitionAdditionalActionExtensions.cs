using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAdditionalAction))]
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
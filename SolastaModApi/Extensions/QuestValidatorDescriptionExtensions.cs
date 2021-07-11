using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(QuestValidatorDescription))]
    public static partial class QuestValidatorDescriptionExtensions
    {
        public static T SetBoolParameter<T>(this T entity, bool value)
            where T : QuestValidatorDescription
        {
            entity.BoolParameter = value;
            return entity;
        }

        public static T SetFloatParameter<T>(this T entity, float value)
            where T : QuestValidatorDescription
        {
            entity.FloatParameter = value;
            return entity;
        }

        public static T SetIntParameter<T>(this T entity, int value)
            where T : QuestValidatorDescription
        {
            entity.IntParameter = value;
            return entity;
        }

        public static T SetQuestUpdateType<T>(this T entity, QuestDefinitions.QuestUpdateType value)
            where T : QuestValidatorDescription
        {
            entity.QuestUpdateType = value;
            return entity;
        }

        public static T SetStringParameter<T>(this T entity, string value)
            where T : QuestValidatorDescription
        {
            entity.StringParameter = value;
            return entity;
        }

        public static T SetStringParameter2<T>(this T entity, string value)
            where T : QuestValidatorDescription
        {
            entity.StringParameter2 = value;
            return entity;
        }

        public static T SetType<T>(this T entity, QuestDefinitions.QuestValidatorType value)
            where T : QuestValidatorDescription
        {
            entity.Type = value;
            return entity;
        }

        public static T SetVariableTest<T>(this T entity, VariableTestDescription value)
            where T : QuestValidatorDescription
        {
            entity.VariableTest = value;
            return entity;
        }

        public static T SetVariableType<T>(this T entity, GameVariableDefinitions.Type value)
            where T : QuestValidatorDescription
        {
            entity.VariableType = value;
            return entity;
        }
    }
}
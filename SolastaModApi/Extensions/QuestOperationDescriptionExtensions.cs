using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(QuestOperationDescription))]
    public static partial class QuestOperationDescriptionExtensions
    {
        public static T SetOutcomeNumber<T>(this T entity, int value)
            where T : QuestOperationDescription
        {
            entity.OutcomeNumber = value;
            return entity;
        }

        public static T SetQuestTreeName<T>(this T entity, string value)
            where T : QuestOperationDescription
        {
            entity.QuestTreeName = value;
            return entity;
        }

        public static T SetStepName<T>(this T entity, string value)
            where T : QuestOperationDescription
        {
            entity.StepName = value;
            return entity;
        }

        public static T SetType<T>(this T entity, string value)
            where T : QuestOperationDescription
        {
            entity.Type = value;
            return entity;
        }
    }
}
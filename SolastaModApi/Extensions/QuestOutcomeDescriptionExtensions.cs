using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(QuestOutcomeDescription))]
    public static partial class QuestOutcomeDescriptionExtensions
    {
        public static T SetDescriptionText<T>(this T entity, string value)
            where T : QuestOutcomeDescription
        {
            entity.DescriptionText = value;
            return entity;
        }

        public static T SetOnCompleteFunctors<T>(this T entity, FunctorParametersListDefinition value)
            where T : QuestOutcomeDescription
        {
            entity.OnCompleteFunctors = value;
            return entity;
        }

        public static T SetOutcomeType<T>(this T entity, QuestDefinitions.QuestOutcomeType value)
            where T : QuestOutcomeDescription
        {
            entity.OutcomeType = value;
            return entity;
        }

        public static T SetValidatorDescription<T>(this T entity, QuestValidatorDescription value)
            where T : QuestOutcomeDescription
        {
            entity.SetField("validatorDescription", value);
            return entity;
        }
    }
}
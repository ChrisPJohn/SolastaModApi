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
        public static T SetValidatorDescription<T>(this T entity, QuestValidatorDescription value)
            where T : QuestOutcomeDescription
        {
            entity.SetField("validatorDescription", value);
            return entity;
        }
    }
}
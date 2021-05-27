using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TutorialStepDefinition))]
    public static class TutorialStepDefinitionExtensions
    {
        public static T SetHideCharacterInspection<T>(this T entity, bool value)
            where T : TutorialStepDefinition
        {
            entity.SetField("hideCharacterInspection", value);
            return entity;
        }

        public static T SetHideJournal<T>(this T entity, bool value)
            where T : TutorialStepDefinition
        {
            entity.SetField("hideJournal", value);
            return entity;
        }

        public static T SetNextStepDefinition<T>(this T entity, TutorialStepDefinition value)
            where T : TutorialStepDefinition
        {
            entity.SetField("nextStepDefinition", value);
            return entity;
        }
    }
}
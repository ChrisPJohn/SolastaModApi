using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(QuestStepDescription))]
    public static class QuestStepDescriptionExtensions
    {
        public static T SetGuiPresentation<T>(this T entity, GuiPresentation value)
            where T : QuestStepDescription
        {
            entity.SetField("guiPresentation", value);
            return entity;
        }
    }
}
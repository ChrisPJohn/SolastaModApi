using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(QuestTreeDefinition))]
    public static partial class QuestTreeDefinitionExtensions
    {
        public static T SetCategory<T>(this T entity, QuestDefinitions.QuestCategory value)
            where T : QuestTreeDefinition
        {
            entity.Category = value;
            return entity;
        }

        public static T SetSerializeVersion<T>(this T entity, int value)
            where T : QuestTreeDefinition
        {
            entity.SetField("serializeVersion", value);
            return entity;
        }
    }
}
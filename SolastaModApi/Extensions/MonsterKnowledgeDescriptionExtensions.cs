using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MonsterKnowledgeDescription))]
    public static class MonsterKnowledgeDescriptionExtensions
    {
        public static T SetKnowledgeLevel<T>(this T entity, string value)
            where T : MonsterKnowledgeDescription
        {
            entity.SetField("knowledgeLevel", value);
            return entity;
        }

        public static T SetMonsterDefinition<T>(this T entity, MonsterDefinition value)
            where T : MonsterKnowledgeDescription
        {
            entity.SetField("monsterDefinition", value);
            return entity;
        }
    }
}
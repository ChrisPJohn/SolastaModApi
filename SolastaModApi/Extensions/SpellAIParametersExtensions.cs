using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SpellAIParameters))]
    public static class SpellAIParametersExtensions
    {
        public static T SetLearnPriority<T>(this T entity, AIDefinitions.AIPriority value)
            where T : SpellAIParameters
        {
            entity.SetField("learnPriority", value);
            return entity;
        }

        public static T SetPreparePriority<T>(this T entity, AIDefinitions.AIPriority value)
            where T : SpellAIParameters
        {
            entity.SetField("preparePriority", value);
            return entity;
        }
    }
}
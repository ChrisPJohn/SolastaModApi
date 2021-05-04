using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
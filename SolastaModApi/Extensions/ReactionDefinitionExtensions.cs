using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ReactionDefinition))]
    public static class ReactionDefinitionExtensions
    {
        public static T SetReactDescription<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactDescription", value);
            return entity;
        }

        public static T SetReactTitle<T>(this T entity, string value)
            where T : ReactionDefinition
        {
            entity.SetField("reactTitle", value);
            return entity;
        }
    }
}
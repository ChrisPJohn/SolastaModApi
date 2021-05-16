using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DeityDefinition))]
    public static class DeityDefinitionExtensions
    {
        public static T SetAlignment<T>(this T entity, string value)
            where T : DeityDefinition
        {
            entity.SetField("alignment", value);
            return entity;
        }

        public static T SetSelectableByPlayer<T>(this T entity, bool value)
            where T : DeityDefinition
        {
            entity.SetField("selectableByPlayer", value);
            return entity;
        }
    }
}
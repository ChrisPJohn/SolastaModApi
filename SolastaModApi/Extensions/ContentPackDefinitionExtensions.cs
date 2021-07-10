using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ContentPackDefinition))]
    public static partial class ContentPackDefinitionExtensions
    {
        public static T SetHideWhenUnavailable<T>(this T entity, bool value)
            where T : ContentPackDefinition
        {
            entity.SetField("hideWhenUnavailable", value);
            return entity;
        }
    }
}
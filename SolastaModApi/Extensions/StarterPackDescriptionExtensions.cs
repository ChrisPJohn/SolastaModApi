using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(StarterPackDescription))]
    public static class StarterPackDescriptionExtensions
    {
        public static T SetContainerItem<T>(this T entity, string value)
            where T : StarterPackDescription
        {
            entity.SetField("containerItem", value);
            return entity;
        }
    }
}
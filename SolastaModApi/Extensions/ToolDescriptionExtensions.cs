using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ToolDescription))]
    public static class ToolDescriptionExtensions
    {
        public static T SetToolType<T>(this T entity, string value)
            where T : ToolDescription
        {
            entity.SetField("toolType", value);
            return entity;
        }
    }
}
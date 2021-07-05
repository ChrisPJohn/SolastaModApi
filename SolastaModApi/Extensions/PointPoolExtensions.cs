using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PointPool))]
    public static partial class PointPoolExtensions
    {
        public static T SetUniqueChoices<T>(this T entity, bool value)
            where T : PointPool
        {
            entity.SetField("uniqueChoices", value);
            return entity;
        }
    }
}
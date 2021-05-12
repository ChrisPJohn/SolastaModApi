using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PointPool))]
    public static class PointPoolExtensions
    {
        public static T SetUniqueChoices<T>(this T entity, bool value)
            where T : PointPool
        {
            entity.SetField("uniqueChoices", value);
            return entity;
        }
    }
}
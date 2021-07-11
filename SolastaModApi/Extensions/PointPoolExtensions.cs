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
        public static T SetDescription<T>(this T entity, string value)
            where T : PointPool
        {
            entity.Description = value;
            return entity;
        }

        public static T SetMaxPoints<T>(this T entity, int value)
            where T : PointPool
        {
            entity.MaxPoints = value;
            return entity;
        }

        public static T SetRemainingPoints<T>(this T entity, int value)
            where T : PointPool
        {
            entity.RemainingPoints = value;
            return entity;
        }

        public static T SetUniqueChoices<T>(this T entity, bool value)
            where T : PointPool
        {
            entity.SetField("uniqueChoices", value);
            return entity;
        }
    }
}
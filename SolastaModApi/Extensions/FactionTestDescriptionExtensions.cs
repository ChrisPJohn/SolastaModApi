using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FactionTestDescription))]
    public static partial class FactionTestDescriptionExtensions
    {
        public static T SetFactionName<T>(this T entity, string value)
            where T : FactionTestDescription
        {
            entity.FactionName = value;
            return entity;
        }

        public static T SetRelationValue<T>(this T entity, int value)
            where T : FactionTestDescription
        {
            entity.RelationValue = value;
            return entity;
        }

        public static T SetStatusValue<T>(this T entity, string value)
            where T : FactionTestDescription
        {
            entity.StatusValue = value;
            return entity;
        }

        public static T SetType<T>(this T entity, string value)
            where T : FactionTestDescription
        {
            entity.Type = value;
            return entity;
        }
    }
}
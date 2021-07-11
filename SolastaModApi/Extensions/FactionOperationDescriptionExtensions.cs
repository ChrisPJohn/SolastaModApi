using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FactionOperationDescription))]
    public static partial class FactionOperationDescriptionExtensions
    {
        public static T SetFactionName<T>(this T entity, string value)
            where T : FactionOperationDescription
        {
            entity.FactionName = value;
            return entity;
        }

        public static T SetOperation<T>(this T entity, FactionDefinition.RelationOperation value)
            where T : FactionOperationDescription
        {
            entity.Operation = value;
            return entity;
        }

        public static T SetStatusName<T>(this T entity, string value)
            where T : FactionOperationDescription
        {
            entity.StatusName = value;
            return entity;
        }

        public static T SetValue<T>(this T entity, int value)
            where T : FactionOperationDescription
        {
            entity.Value = value;
            return entity;
        }
    }
}
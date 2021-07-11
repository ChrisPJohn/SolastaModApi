using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EnableWieldedItemsDescription))]
    public static partial class EnableWieldedItemsDescriptionExtensions
    {
        public static T SetEnabled<T>(this T entity, bool value)
            where T : EnableWieldedItemsDescription
        {
            entity.Enabled = value;
            return entity;
        }

        public static T SetRole<T>(this T entity, string value)
            where T : EnableWieldedItemsDescription
        {
            entity.Role = value;
            return entity;
        }
    }
}
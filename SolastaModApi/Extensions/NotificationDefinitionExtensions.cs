using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(NotificationDefinition))]
    public static class NotificationDefinitionExtensions
    {
        public static T SetContextualImageSize<T>(this T entity, Vector2 value)
            where T : NotificationDefinition
        {
            entity.SetField("contextualImageSize", value);
            return entity;
        }

        public static T SetDisplayType<T>(this T entity, NotificationDefinitions.DisplayType value)
            where T : NotificationDefinition
        {
            entity.SetField("displayType", value);
            return entity;
        }
    }
}
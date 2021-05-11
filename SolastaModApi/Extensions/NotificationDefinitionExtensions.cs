using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
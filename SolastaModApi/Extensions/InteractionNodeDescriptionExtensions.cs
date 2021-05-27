using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(InteractionNodeDescription))]
    public static class InteractionNodeDescriptionExtensions
    {
        public static T SetOrientation<T>(this T entity, LocationDefinitions.Orientation value)
            where T : InteractionNodeDescription
        {
            entity.SetField("orientation", value);
            return entity;
        }

        public static T SetPosition<T>(this T entity, Vector2 value)
            where T : InteractionNodeDescription
        {
            entity.SetField("position", value);
            return entity;
        }
    }
}
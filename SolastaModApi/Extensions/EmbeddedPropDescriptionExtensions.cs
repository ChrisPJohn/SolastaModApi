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
    [TargetType(typeof(EmbeddedPropDescription))]
    public static class EmbeddedPropDescriptionExtensions
    {
        public static T SetOrientation<T>(this T entity, LocationDefinitions.Orientation value)
            where T : EmbeddedPropDescription
        {
            entity.SetField("orientation", value);
            return entity;
        }

        public static T SetPosition<T>(this T entity, Vector2Int value)
            where T : EmbeddedPropDescription
        {
            entity.SetField("position", value);
            return entity;
        }

        public static T SetPropBlueprint<T>(this T entity, PropBlueprint value)
            where T : EmbeddedPropDescription
        {
            entity.SetField("propBlueprint", value);
            return entity;
        }
    }
}
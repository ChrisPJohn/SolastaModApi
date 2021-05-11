using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EmbeddedGadgetDescription))]
    public static class EmbeddedGadgetDescriptionExtensions
    {
        public static T SetGadgetBlueprint<T>(this T entity, GadgetBlueprint value)
            where T : EmbeddedGadgetDescription
        {
            entity.SetField("gadgetBlueprint", value);
            return entity;
        }

        public static T SetOrientation<T>(this T entity, LocationDefinitions.Orientation value)
            where T : EmbeddedGadgetDescription
        {
            entity.SetField("orientation", value);
            return entity;
        }

        public static T SetPosition<T>(this T entity, Vector2Int value)
            where T : EmbeddedGadgetDescription
        {
            entity.SetField("position", value);
            return entity;
        }
    }
}
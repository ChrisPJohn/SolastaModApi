using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(BaseBlueprint))]
    public static partial class BaseBlueprintExtensions
    {
        public static T SetCategory<T>(this T entity, string value)
            where T : BaseBlueprint
        {
            entity.SetField("category", value);
            return entity;
        }

        public static T SetDimensions<T>(this T entity, Vector2Int value)
            where T : BaseBlueprint
        {
            entity.SetField("dimensions", value);
            return entity;
        }
    }
}
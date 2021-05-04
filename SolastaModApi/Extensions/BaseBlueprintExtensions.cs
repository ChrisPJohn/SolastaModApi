using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class BaseBlueprintExtensions
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
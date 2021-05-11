using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static BaseBlueprint;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class PrefabByEnvironmentDescriptionExtensions
    {
        public static T SetEnvironment<T>(this T entity, string value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("environment", value);
            return entity;
        }

        public static T SetPerspectiveSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("perspectiveSpriteReference", value);
            return entity;
        }

        public static T SetPrefabReference<T>(this T entity, AssetReference value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("prefabReference", value);
            return entity;
        }

        public static T SetTopSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("topSpriteReference", value);
            return entity;
        }
    }
}
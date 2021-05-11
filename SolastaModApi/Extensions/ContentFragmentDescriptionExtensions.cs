using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ContentFragmentDescriptionExtensions
    {
        public static T SetSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : ContentFragmentDescription
        {
            entity.SetField("spriteReference", value);
            return entity;
        }

        public static T SetText<T>(this T entity, string value)
            where T : ContentFragmentDescription
        {
            entity.SetField("text", value);
            return entity;
        }

        public static T SetType<T>(this T entity, ContentFragmentDescription.FragmentType value)
            where T : ContentFragmentDescription
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}
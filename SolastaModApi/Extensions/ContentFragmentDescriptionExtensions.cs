using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ContentFragmentDescription))]
    public static partial class ContentFragmentDescriptionExtensions
    {
        public static T SetSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : ContentFragmentDescription
        {
            entity.SpriteReference = value;
            return entity;
        }

        public static T SetText<T>(this T entity, string value)
            where T : ContentFragmentDescription
        {
            entity.Text = value;
            return entity;
        }

        public static T SetType<T>(this T entity, ContentFragmentDescription.FragmentType value)
            where T : ContentFragmentDescription
        {
            entity.Type = value;
            return entity;
        }
    }
}
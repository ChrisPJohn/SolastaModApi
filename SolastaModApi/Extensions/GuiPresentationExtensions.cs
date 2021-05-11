using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiPresentation))]
    public static class GuiPresentationExtensions
    {
        public static T SetColor<T>(this T entity, Color value)
            where T : GuiPresentation
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetHidden<T>(this T entity, bool value)
            where T : GuiPresentation
        {
            entity.SetField("hidden", value);
            return entity;
        }

        public static T SetSortOrder<T>(this T entity, int value)
            where T : GuiPresentation
        {
            entity.SetField("sortOrder", value);
            return entity;
        }

        public static T SetSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : GuiPresentation
        {
            entity.SetField("spriteReference", value);
            return entity;
        }

        public static T SetSymbolChar<T>(this T entity, string value)
            where T : GuiPresentation
        {
            entity.SetField("symbolChar", value);
            return entity;
        }
    }
}
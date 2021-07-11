using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static CreditsGroupDefinition;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CreditsEntryDescription))]
    public static partial class CreditsEntryDescriptionExtensions
    {
        public static T SetEntryType<T>(this T entity, EntryType value)
            where T : CreditsEntryDescription
        {
            entity.EntryType = value;
            return entity;
        }

        public static T SetImageHeight<T>(this T entity, float value)
            where T : CreditsEntryDescription
        {
            entity.SetField("imageHeight", value);
            return entity;
        }

        public static T SetSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : CreditsEntryDescription
        {
            entity.SetField("spriteReference", value);
            return entity;
        }

        public static T SetTextContent<T>(this T entity, string value)
            where T : CreditsEntryDescription
        {
            entity.TextContent = value;
            return entity;
        }
    }
}
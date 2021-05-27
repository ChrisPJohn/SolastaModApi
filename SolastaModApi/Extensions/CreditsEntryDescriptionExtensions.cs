using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static CreditsGroupDefinition;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(CreditsEntryDescription))]
    public static class CreditsEntryDescriptionExtensions
    {
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
    }
}
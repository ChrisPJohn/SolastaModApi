using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FallbackImageDescription))]
    public static class FallbackImageDescriptionExtensions
    {
        public static T SetFallbackReference<T>(this T entity, AssetReference value)
            where T : FallbackImageDescription
        {
            entity.SetField("fallbackReference", value);
            return entity;
        }

        public static T SetStartSecond<T>(this T entity, float value)
            where T : FallbackImageDescription
        {
            entity.SetField("startSecond", value);
            return entity;
        }
    }
}
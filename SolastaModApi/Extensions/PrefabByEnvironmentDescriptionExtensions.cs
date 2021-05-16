using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static BaseBlueprint;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PrefabByEnvironmentDescription))]
    public static class PrefabByEnvironmentDescriptionExtensions
    {
        public static T SetEnvironment<T>(this T entity, string value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("environment", value);
            return entity;
        }

        public static T SetPrefabReference<T>(this T entity, AssetReference value)
            where T : PrefabByEnvironmentDescription
        {
            entity.SetField("prefabReference", value);
            return entity;
        }
    }
}
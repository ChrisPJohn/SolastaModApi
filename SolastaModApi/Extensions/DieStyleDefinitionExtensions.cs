using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DieStyleDefinition))]
    public static class DieStyleDefinitionExtensions
    {
        public static T SetD10MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d10MaterialReference", value);
            return entity;
        }

        public static T SetD12MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d12MaterialReference", value);
            return entity;
        }

        public static T SetD20MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d20MaterialReference", value);
            return entity;
        }

        public static T SetD4MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d4MaterialReference", value);
            return entity;
        }

        public static T SetD6MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d6MaterialReference", value);
            return entity;
        }

        public static T SetD8MaterialReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("d8MaterialReference", value);
            return entity;
        }

        public static T SetParticlePrefabReference<T>(this T entity, AssetReference value)
            where T : DieStyleDefinition
        {
            entity.SetField("particlePrefabReference", value);
            return entity;
        }

        public static T SetUseMetallicLayer<T>(this T entity, bool value)
            where T : DieStyleDefinition
        {
            entity.SetField("useMetallicLayer", value);
            return entity;
        }
    }
}
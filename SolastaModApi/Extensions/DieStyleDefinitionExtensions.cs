using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
    }
}
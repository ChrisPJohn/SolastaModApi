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
    public static class LightSourceFormExtensions
    {
        public static T SetBrightRange<T>(this T entity, int value)
            where T : LightSourceForm
        {
            entity.SetField("brightRange", value);
            return entity;
        }

        public static T SetColor<T>(this T entity, Color value)
            where T : LightSourceForm
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetDimAdditionalRange<T>(this T entity, int value)
            where T : LightSourceForm
        {
            entity.SetField("dimAdditionalRange", value);
            return entity;
        }

        public static T SetGraphicsPrefabReference<T>(this T entity, AssetReference value)
            where T : LightSourceForm
        {
            entity.SetField("graphicsPrefabReference", value);
            return entity;
        }

        public static T SetLightSourceType<T>(this T entity, LightSourceType value)
            where T : LightSourceForm
        {
            entity.SetField("lightSourceType", value);
            return entity;
        }
    }
}
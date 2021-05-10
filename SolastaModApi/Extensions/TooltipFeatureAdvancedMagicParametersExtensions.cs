using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TooltipFeatureAdvancedMagicParametersExtensions
    {
        public static T SetAdvancedImage<T>(this T entity, Image value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("advancedImage", value);
            return entity;
        }

        public static T SetShapeConeCenteredSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeConeCenteredSprite", value);
            return entity;
        }

        public static T SetShapeCubeCenteredSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeCubeCenteredSprite", value);
            return entity;
        }

        public static T SetShapeCubeCenteredWithOffsetSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeCubeCenteredWithOffsetSprite", value);
            return entity;
        }

        public static T SetShapeCubeSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeCubeSprite", value);
            return entity;
        }

        public static T SetShapeCylinderSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeCylinderSprite", value);
            return entity;
        }

        public static T SetShapeLineCenteredSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeLineCenteredSprite", value);
            return entity;
        }

        public static T SetShapePerceivingWithinDistanceSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapePerceivingWithinDistanceSprite", value);
            return entity;
        }

        public static T SetShapeSphereCenteredSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeSphereCenteredSprite", value);
            return entity;
        }

        public static T SetShapeSphereSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeSphereSprite", value);
            return entity;
        }

        public static T SetShapeWallLineSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeWallLineSprite", value);
            return entity;
        }

        public static T SetShapeWallRingSprite<T>(this T entity, AssetReferenceSprite value)
            where T : TooltipFeatureAdvancedMagicParameters
        {
            entity.SetField("shapeWallRingSprite", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RoomBlueprint))]
    public static partial class RoomBlueprintExtensions
    {
        public static T SetCellInfos<T>(this T entity, int[] value)
            where T : RoomBlueprint
        {
            entity.SetField("cellInfos", value);
            return entity;
        }

        public static T SetEmbeddedGadgets<T>(this T entity, EmbeddedGadgetDescription[] value)
            where T : RoomBlueprint
        {
            entity.SetField("embeddedGadgets", value);
            return entity;
        }

        public static T SetEmbeddedProps<T>(this T entity, EmbeddedPropDescription[] value)
            where T : RoomBlueprint
        {
            entity.SetField("embeddedProps", value);
            return entity;
        }

        public static T SetGroundElevationSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : RoomBlueprint
        {
            entity.SetField("groundElevationSpriteReference", value);
            return entity;
        }

        public static T SetGroundMaskSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : RoomBlueprint
        {
            entity.SetField("groundMaskSpriteReference", value);
            return entity;
        }

        public static T SetSurfaceInfos<T>(this T entity, int[] value)
            where T : RoomBlueprint
        {
            entity.SetField("surfaceInfos", value);
            return entity;
        }

        public static T SetWallAndOpeningSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallAndOpeningSpriteReference", value);
            return entity;
        }

        public static T SetWallSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallSpriteReference", value);
            return entity;
        }
    }
}
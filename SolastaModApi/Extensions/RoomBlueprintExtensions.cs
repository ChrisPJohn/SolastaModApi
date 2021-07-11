using SolastaModApi.Infrastructure;
using UnityEngine;
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

        public static T SetGroundElevationSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("groundElevationSprite", value);
            return entity;
        }

        public static T SetGroundMaskSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("groundMaskSprite", value);
            return entity;
        }

        public static T SetWallAndOpeningSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallAndOpeningSprite", value);
            return entity;
        }

        public static T SetWallSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallSprite", value);
            return entity;
        }
    }
}
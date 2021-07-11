using System;
using UnityEngine;

namespace SolastaModApi.Extensions
{
    public static partial class RoomBlueprintExtensions
    {
        [Obsolete("Use SetGroundMaskSprite")]
        public static T SetGrounMaskSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetGroundMaskSprite(value);
            return entity;
        }
    }
}

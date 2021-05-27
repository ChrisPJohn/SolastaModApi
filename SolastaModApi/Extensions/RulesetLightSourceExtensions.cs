using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetLightSource))]
    public static class RulesetLightSourceExtensions
    {
        public static T SetAssetGUID<T>(this T entity, string value)
            where T : RulesetLightSource
        {
            entity.SetField("assetGUID", value);
            return entity;
        }

        public static T SetBrightRange<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("brightRange", value);
            return entity;
        }

        public static T SetColor<T>(this T entity, Color value)
            where T : RulesetLightSource
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetDayCycleType<T>(this T entity, LightSourceDayCycleType value)
            where T : RulesetLightSource
        {
            entity.SetField("dayCycleType", value);
            return entity;
        }

        public static T SetDimRange<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("dimRange", value);
            return entity;
        }

        public static T SetIsSpot<T>(this T entity, bool value)
            where T : RulesetLightSource
        {
            entity.SetField("isSpot", value);
            return entity;
        }

        public static T SetLightSourceDayCycleActiveChanged<T>(this T entity, RulesetLightSource.LightSourceDayCycleActiveChangedHandler value)
            where T : RulesetLightSource
        {
            entity.SetField("<LightSourceDayCycleActiveChanged>k__BackingField", value);
            return entity;
        }

        public static T SetLightSourceExtinguished<T>(this T entity, RulesetLightSource.LightSourceExtinguishedHandler value)
            where T : RulesetLightSource
        {
            entity.SetField("<LightSourceExtinguished>k__BackingField", value);
            return entity;
        }

        public static T SetLightSourceObscurationChanged<T>(this T entity, RulesetLightSource.LightSourceObscurationChangedHandler value)
            where T : RulesetLightSource
        {
            entity.SetField("<LightSourceObscurationChanged>k__BackingField", value);
            return entity;
        }

        public static T SetLightSourceType<T>(this T entity, LightSourceType value)
            where T : RulesetLightSource
        {
            entity.SetField("lightSourceType", value);
            return entity;
        }

        public static T SetSourceName<T>(this T entity, string value)
            where T : RulesetLightSource
        {
            entity.SetField("sourceName", value);
            return entity;
        }

        public static T SetSpecificLocationPosition<T>(this T entity, int3 value)
            where T : RulesetLightSource
        {
            entity.SetField("specificLocationPosition", value);
            return entity;
        }

        public static T SetSpotAngle<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("spotAngle", value);
            return entity;
        }

        public static T SetSpotDirection<T>(this T entity, Vector3 value)
            where T : RulesetLightSource
        {
            entity.SetField("spotDirection", value);
            return entity;
        }

        public static T SetTargetGuid<T>(this T entity, ulong value)
            where T : RulesetLightSource
        {
            entity.SetField("targetGuid", value);
            return entity;
        }

        public static T SetTargetItemGuid<T>(this T entity, ulong value)
            where T : RulesetLightSource
        {
            entity.SetField("targetItemGuid", value);
            return entity;
        }

        public static T SetUseSpecificLocationPosition<T>(this T entity, bool value)
            where T : RulesetLightSource
        {
            entity.SetField("useSpecificLocationPosition", value);
            return entity;
        }
    }
}
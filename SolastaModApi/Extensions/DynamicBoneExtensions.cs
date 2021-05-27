using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DynamicBone))]
    public static class DynamicBoneExtensions
    {
        public static T SetBoneTotalLength<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_BoneTotalLength", value);
            return entity;
        }

        public static T SetDistantDisabled<T>(this T entity, bool value)
            where T : DynamicBone
        {
            entity.SetField("m_DistantDisabled", value);
            return entity;
        }

        public static T SetLocalGravity<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_LocalGravity", value);
            return entity;
        }

        public static T SetObjectMove<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectMove", value);
            return entity;
        }

        public static T SetObjectPrevPosition<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectPrevPosition", value);
            return entity;
        }

        public static T SetObjectScale<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectScale", value);
            return entity;
        }

        public static T SetTime<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_Time", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_Weight", value);
            return entity;
        }
    }
}
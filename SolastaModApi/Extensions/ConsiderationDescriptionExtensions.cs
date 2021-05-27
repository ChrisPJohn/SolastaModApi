using SolastaModApi.Infrastructure;
using UnityEngine;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ConsiderationDescription))]
    public static class ConsiderationDescriptionExtensions
    {
        public static T SetBoolParameter<T>(this T entity, bool value)
            where T : ConsiderationDescription
        {
            entity.SetField("boolParameter", value);
            return entity;
        }

        public static T SetBoolSecParameter<T>(this T entity, bool value)
            where T : ConsiderationDescription
        {
            entity.SetField("boolSecParameter", value);
            return entity;
        }

        public static T SetBoolTerParameter<T>(this T entity, bool value)
            where T : ConsiderationDescription
        {
            entity.SetField("boolTerParameter", value);
            return entity;
        }

        public static T SetByteParameter<T>(this T entity, byte value)
            where T : ConsiderationDescription
        {
            entity.SetField("byteParameter", value);
            return entity;
        }

        public static T SetConsiderationType<T>(this T entity, string value)
            where T : ConsiderationDescription
        {
            entity.SetField("considerationType", value);
            return entity;
        }

        public static T SetCurve<T>(this T entity, AnimationCurve value)
            where T : ConsiderationDescription
        {
            entity.SetField("curve", value);
            return entity;
        }

        public static T SetFloatParameter<T>(this T entity, float value)
            where T : ConsiderationDescription
        {
            entity.SetField("floatParameter", value);
            return entity;
        }

        public static T SetIntParameter<T>(this T entity, int value)
            where T : ConsiderationDescription
        {
            entity.SetField("intParameter", value);
            return entity;
        }

        public static T SetStringParameter<T>(this T entity, string value)
            where T : ConsiderationDescription
        {
            entity.SetField("stringParameter", value);
            return entity;
        }
    }
}
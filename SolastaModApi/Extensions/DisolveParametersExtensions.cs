using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;
using static GraphicsCharacterDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DisolveParameters))]
    public static partial class DisolveParametersExtensions
    {
        public static T SetColor<T>(this T entity, Color value)
            where T : DisolveParameters
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetColorWidth<T>(this T entity, float value)
            where T : DisolveParameters
        {
            entity.SetField("colorWidth", value);
            return entity;
        }

        public static T SetCurve<T>(this T entity, AnimationCurve value)
            where T : DisolveParameters
        {
            entity.SetField("curve", value);
            return entity;
        }

        public static T SetDuration<T>(this T entity, float value)
            where T : DisolveParameters
        {
            entity.SetField("duration", value);
            return entity;
        }

        public static T SetHueScale<T>(this T entity, float value)
            where T : DisolveParameters
        {
            entity.SetField("hueScale", value);
            return entity;
        }

        public static T SetNoiseScale<T>(this T entity, float value)
            where T : DisolveParameters
        {
            entity.SetField("noiseScale", value);
            return entity;
        }

        public static T SetVertexOffset<T>(this T entity, float value)
            where T : DisolveParameters
        {
            entity.SetField("vertexOffset", value);
            return entity;
        }
    }
}
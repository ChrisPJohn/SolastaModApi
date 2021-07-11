using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DialogCameraMovementParameters))]
    public static partial class DialogCameraMovementParametersExtensions
    {
        public static T SetAccelerationDuration<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.AccelerationDuration = value;
            return entity;
        }

        public static T SetDollySpeed<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.DollySpeed = value;
            return entity;
        }

        public static T SetOrbitalSpeed<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.OrbitalSpeed = value;
            return entity;
        }

        public static T SetSpeedForward<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.SpeedForward = value;
            return entity;
        }

        public static T SetSpeedRight<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.SpeedRight = value;
            return entity;
        }

        public static T SetSpeedUp<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.SpeedUp = value;
            return entity;
        }

        public static T SetZoomDuration<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.ZoomDuration = value;
            return entity;
        }

        public static T SetZoomFrom<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.ZoomFrom = value;
            return entity;
        }

        public static T SetZoomTo<T>(this T entity, float value)
            where T : DialogCameraMovementParameters
        {
            entity.ZoomTo = value;
            return entity;
        }
    }
}
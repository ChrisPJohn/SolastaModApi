using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class MapWaypointDefinitionExtensions
    {
        public static T SetAllowFastTravel<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("allowFastTravel", value);
            return entity;
        }

        public static T SetCameraAngle<T>(this T entity, float value)
            where T : MapWaypointDefinition
        {
            entity.SetField("cameraAngle", value);
            return entity;
        }

        public static T SetForceCameraOrientation<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("forceCameraOrientation", value);
            return entity;
        }

        public static T SetLocationExit<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("locationExit", value);
            return entity;
        }

        public static T SetLongRestAvailable<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("longRestAvailable", value);
            return entity;
        }
    }
}
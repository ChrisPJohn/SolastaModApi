using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MotionForm))]
    public static class MotionFormExtensions
    {
        public static T SetDistance<T>(this T entity, int value)
            where T : MotionForm
        {
            entity.SetField("distance", value);
            return entity;
        }

        public static T SetType<T>(this T entity, MotionForm.MotionType value)
            where T : MotionForm
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}
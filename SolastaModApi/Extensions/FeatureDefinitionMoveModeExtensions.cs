using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionMoveMode))]
    public static class FeatureDefinitionMoveModeExtensions
    {
        public static T SetMoveMode<T>(this T entity, MoveMode value)
            where T : FeatureDefinitionMoveMode
        {
            entity.SetField("moveMode", value);
            return entity;
        }

        public static T SetSpeed<T>(this T entity, int value)
            where T : FeatureDefinitionMoveMode
        {
            entity.SetField("speed", value);
            return entity;
        }
    }
}
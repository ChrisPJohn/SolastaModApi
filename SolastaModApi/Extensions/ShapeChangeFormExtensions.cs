using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ShapeChangeForm))]
    public static partial class ShapeChangeFormExtensions
    {
        public static T SetKeepMentalAbilityScores<T>(this T entity, bool value)
            where T : ShapeChangeForm
        {
            entity.SetField("keepMentalAbilityScores", value);
            return entity;
        }

        public static T SetShapeChangeType<T>(this T entity, ShapeChangeForm.Type value)
            where T : ShapeChangeForm
        {
            entity.SetField("shapeChangeType", value);
            return entity;
        }

        public static T SetSpecialSubstituteCondition<T>(this T entity, ConditionDefinition value)
            where T : ShapeChangeForm
        {
            entity.SetField("specialSubstituteCondition", value);
            return entity;
        }
    }
}
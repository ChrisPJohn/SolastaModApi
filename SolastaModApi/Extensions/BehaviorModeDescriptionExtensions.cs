using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(BehaviorModeDescription))]
    public static class BehaviorModeDescriptionExtensions
    {
        public static T SetBehaviour<T>(this T entity, RandomBehaviour value)
            where T : BehaviorModeDescription
        {
            entity.SetField("behaviour", value);
            return entity;
        }

        public static T SetCondition<T>(this T entity, ConditionDefinition value)
            where T : BehaviorModeDescription
        {
            entity.SetField("condition", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, int value)
            where T : BehaviorModeDescription
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
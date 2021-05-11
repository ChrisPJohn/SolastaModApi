using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DecisionDescription))]
    public static class DecisionDescriptionExtensions
    {
        public static T SetActivityType<T>(this T entity, string value)
            where T : DecisionDescription
        {
            entity.SetField("activityType", value);
            return entity;
        }

        public static T SetBoolParameter<T>(this T entity, bool value)
            where T : DecisionDescription
        {
            entity.SetField("boolParameter", value);
            return entity;
        }

        public static T SetBoolSecParameter<T>(this T entity, bool value)
            where T : DecisionDescription
        {
            entity.SetField("boolSecParameter", value);
            return entity;
        }

        public static T SetDescription<T>(this T entity, string value)
            where T : DecisionDescription
        {
            entity.SetField("description", value);
            return entity;
        }

        public static T SetEnumParameter<T>(this T entity, int value)
            where T : DecisionDescription
        {
            entity.SetField("enumParameter", value);
            return entity;
        }

        public static T SetFloatParameter<T>(this T entity, float value)
            where T : DecisionDescription
        {
            entity.SetField("floatParameter", value);
            return entity;
        }

        public static T SetScorer<T>(this T entity, ActivityScorerDefinition value)
            where T : DecisionDescription
        {
            entity.SetField("scorer", value);
            return entity;
        }

        public static T SetStringParameter<T>(this T entity, string value)
            where T : DecisionDescription
        {
            entity.SetField("stringParameter", value);
            return entity;
        }

        public static T SetStringSecParameter<T>(this T entity, string value)
            where T : DecisionDescription
        {
            entity.SetField("stringSecParameter", value);
            return entity;
        }
    }
}
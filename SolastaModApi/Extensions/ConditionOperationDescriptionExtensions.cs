using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(ConditionOperationDescription))]
    public static class ConditionOperationDescriptionExtensions
    {
        public static T SetCanSaveToCancel<T>(this T entity, bool value)
            where T : ConditionOperationDescription
        {
            entity.SetField("canSaveToCancel", value);
            return entity;
        }

        public static T SetConditionName<T>(this T entity, string value)
            where T : ConditionOperationDescription
        {
            entity.SetField("conditionName", value);
            return entity;
        }

        public static T SetHasSavingThrow<T>(this T entity, bool value)
            where T : ConditionOperationDescription
        {
            entity.SetField("hasSavingThrow", value);
            return entity;
        }

        public static T SetSaveAffinity<T>(this T entity, EffectSavingThrowType value)
            where T : ConditionOperationDescription
        {
            entity.SetField("saveAffinity", value);
            return entity;
        }

        public static T SetSaveOccurence<T>(this T entity, TurnOccurenceType value)
            where T : ConditionOperationDescription
        {
            entity.SetField("saveOccurence", value);
            return entity;
        }
    }
}
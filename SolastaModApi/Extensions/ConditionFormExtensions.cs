using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class ConditionFormExtensions
    {
        public static T SetApplyToSelf<T>(this T entity, bool value)
            where T : ConditionForm
        {
            entity.SetField("applyToSelf", value);
            return entity;
        }

        public static T SetConditionDefinitionName<T>(this T entity, string value)
            where T : ConditionForm
        {
            entity.SetField("conditionDefinitionName", value);
            return entity;
        }

        public static T SetForceOnSelf<T>(this T entity, bool value)
            where T : ConditionForm
        {
            entity.SetField("forceOnSelf", value);
            return entity;
        }
    }
}
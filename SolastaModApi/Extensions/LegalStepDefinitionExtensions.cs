using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(LegalStepDefinition))]
    public static class LegalStepDefinitionExtensions
    {
        public static T SetPreferenceKey<T>(this T entity, string value)
            where T : LegalStepDefinition
        {
            entity.SetField("preferenceKey", value);
            return entity;
        }

        public static T SetRequiresAgreement<T>(this T entity, bool value)
            where T : LegalStepDefinition
        {
            entity.SetField("requiresAgreement", value);
            return entity;
        }
    }
}
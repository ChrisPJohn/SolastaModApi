using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SaveAffinityBySenseDescription))]
    public static class SaveAffinityBySenseDescriptionExtensions
    {
        public static T SetAdvantageType<T>(this T entity, AdvantageType value)
            where T : SaveAffinityBySenseDescription
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetSenseType<T>(this T entity, SenseMode.Type value)
            where T : SaveAffinityBySenseDescription
        {
            entity.SetField("senseType", value);
            return entity;
        }
    }
}
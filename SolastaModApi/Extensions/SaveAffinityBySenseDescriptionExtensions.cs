using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
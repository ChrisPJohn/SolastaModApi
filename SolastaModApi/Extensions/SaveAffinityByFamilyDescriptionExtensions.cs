using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SaveAffinityByFamilyDescription))]
    public static partial class SaveAffinityByFamilyDescriptionExtensions
    {
        public static T SetAdvantageType<T>(this T entity, AdvantageType value)
            where T : SaveAffinityByFamilyDescription
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetFamily<T>(this T entity, string value)
            where T : SaveAffinityByFamilyDescription
        {
            entity.SetField("family", value);
            return entity;
        }
    }
}
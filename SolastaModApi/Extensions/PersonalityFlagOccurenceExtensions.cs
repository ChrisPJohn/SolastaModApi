using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(PersonalityFlagOccurence))]
    public static class PersonalityFlagOccurenceExtensions
    {
        public static T SetPersonalityFlag<T>(this T entity, string value)
            where T : PersonalityFlagOccurence
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, int value)
            where T : PersonalityFlagOccurence
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionCharacterPresentation))]
    public static partial class FeatureDefinitionCharacterPresentationExtensions
    {
        public static T SetForcedBeard<T>(this T entity, string value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("forcedBeard", value);
            return entity;
        }

        public static T SetKeepExistingBeardList<T>(this T entity, string[] value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("keepExistingBeardList", value);
            return entity;
        }

        public static T SetOccurencePercentage<T>(this T entity, int value)
            where T : FeatureDefinitionCharacterPresentation
        {
            entity.SetField("occurencePercentage", value);
            return entity;
        }
    }
}
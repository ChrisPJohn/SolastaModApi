using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(LocationPresentation))]
    public static class LocationPresentationExtensions
    {
        public static T SetExploredDescription<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("exploredDescription", value);
            return entity;
        }

        public static T SetExploredTitle<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("exploredTitle", value);
            return entity;
        }

        public static T SetKnownDescription<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("knownDescription", value);
            return entity;
        }

        public static T SetKnownTitle<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("knownTitle", value);
            return entity;
        }

        public static T SetUnchartedDescription<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("unchartedDescription", value);
            return entity;
        }

        public static T SetUnchartedTitle<T>(this T entity, string value)
            where T : LocationPresentation
        {
            entity.SetField("unchartedTitle", value);
            return entity;
        }
    }
}
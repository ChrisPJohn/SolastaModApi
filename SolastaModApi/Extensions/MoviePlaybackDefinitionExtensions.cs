using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MoviePlaybackDefinition))]
    public static partial class MoviePlaybackDefinitionExtensions
    {
        public static T SetMovieFilename<T>(this T entity, string value)
            where T : MoviePlaybackDefinition
        {
            entity.SetField("movieFilename", value);
            return entity;
        }

        public static T SetTotalFallbackDuration<T>(this T entity, float value)
            where T : MoviePlaybackDefinition
        {
            entity.SetField("totalFallbackDuration", value);
            return entity;
        }
    }
}
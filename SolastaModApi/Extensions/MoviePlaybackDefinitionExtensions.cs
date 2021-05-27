using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MoviePlaybackDefinition))]
    public static class MoviePlaybackDefinitionExtensions
    {
        public static T SetMovieFilename<T>(this T entity, string value)
            where T : MoviePlaybackDefinition
        {
            entity.SetField("movieFilename", value);
            return entity;
        }
    }
}
using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
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
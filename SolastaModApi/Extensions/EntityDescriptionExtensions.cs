using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EntityDescription))]
    public static partial class EntityDescriptionExtensions
    {
        public static T SetAction<T>(this T entity, EntityDescription.DescriptionAction value)
            where T : EntityDescription
        {
            entity.Action = value;
            return entity;
        }

        public static T SetCover<T>(this T entity, CoverType value)
            where T : EntityDescription
        {
            entity.Cover = value;
            return entity;
        }

        public static T SetFailure<T>(this T entity, string value)
            where T : EntityDescription
        {
            entity.Failure = value;
            return entity;
        }

        public static T SetHeader<T>(this T entity, string value)
            where T : EntityDescription
        {
            entity.Header = value;
            return entity;
        }
    }
}
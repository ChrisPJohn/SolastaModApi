using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// It's not guaranteed to work against any other version of Solasta.
    /// If you find an issue please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class BaseDefinitionExtensions
    {
        public static T SetCachedName<T>(this T entity, string value)
            where T : BaseDefinition
        {
            entity.SetField("cachedName", value);
            return entity;
        }

        public static T SetContentCopyright<T>(this T entity, BaseDefinition.Copyright value)
            where T : BaseDefinition
        {
            entity.SetField("contentCopyright", value);
            return entity;
        }

        public static T SetGuid<T>(this T entity, string value)
            where T : BaseDefinition
        {
            entity.SetField("guid", value);
            return entity;
        }

        public static T SetGuiPresentation<T>(this T entity, GuiPresentation value)
            where T : BaseDefinition
        {
            entity.SetField("guiPresentation", value);
            return entity;
        }
    }
}
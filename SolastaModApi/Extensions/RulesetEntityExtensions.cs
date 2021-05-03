using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetEntityExtensions
    {
        public static T SetEntityDescription<T>(this T entity, EntityDescription value)
            where T : RulesetEntity
        {
            entity.SetField("entityDescription", value);
            return entity;
        }

        public static T SetGuid<T>(this T entity, ulong value)
            where T : RulesetEntity
        {
            entity.SetField("guid", value);
            return entity;
        }
    }
}
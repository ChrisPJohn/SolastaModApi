using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class TopologyFormExtensions
    {
        public static T SetChangeType<T>(this T entity, TopologyForm.Type value)
            where T : TopologyForm
        {
            entity.SetField("changeType", value);
            return entity;
        }

        public static T SetImpactsFlyingCharacters<T>(this T entity, bool value)
            where T : TopologyForm
        {
            entity.SetField("impactsFlyingCharacters", value);
            return entity;
        }
    }
}
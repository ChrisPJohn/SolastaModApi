using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class WeightedConsiderationDescriptionExtensions
    {
        public static T SetConsiderationDefinition<T>(this T entity, ConsiderationDefinition value)
            where T : WeightedConsiderationDescription
        {
            entity.SetField("consideration", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : WeightedConsiderationDescription
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}
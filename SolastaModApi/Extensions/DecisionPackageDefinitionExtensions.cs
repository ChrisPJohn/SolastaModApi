using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class DecisionPackageDefinitionExtensions
    {
        public static T SetPackage<T>(this T entity, DecisionPackageDescription value)
            where T : DecisionPackageDefinition
        {
            entity.SetField("package", value);
            return entity;
        }
    }
}
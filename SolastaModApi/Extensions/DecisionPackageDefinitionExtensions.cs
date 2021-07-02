using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DecisionPackageDefinition))]
    public static partial class DecisionPackageDefinitionExtensions
    {
        public static T SetPackage<T>(this T entity, DecisionPackageDescription value)
            where T : DecisionPackageDefinition
        {
            entity.SetField("package", value);
            return entity;
        }
    }
}
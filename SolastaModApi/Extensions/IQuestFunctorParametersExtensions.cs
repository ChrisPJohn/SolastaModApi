using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(IQuestFunctorParameters))]
    public static partial class IQuestFunctorParametersExtensions
    {
        public static T SetFunctorIndex<T>(this T entity, int value)
            where T : IQuestFunctorParameters
        {
            entity.FunctorIndex = value;
            return entity;
        }
    }
}
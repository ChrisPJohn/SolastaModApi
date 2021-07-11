using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(IGadgetFunctorParameters))]
    public static partial class IGadgetFunctorParametersExtensions
    {
        public static T SetFlowId<T>(this T entity, string value)
            where T : IGadgetFunctorParameters
        {
            entity.FlowId = value;
            return entity;
        }

        public static T SetFunctorIndex<T>(this T entity, int value)
            where T : IGadgetFunctorParameters
        {
            entity.FunctorIndex = value;
            return entity;
        }

        public static T SetListenerIndex<T>(this T entity, int value)
            where T : IGadgetFunctorParameters
        {
            entity.ListenerIndex = value;
            return entity;
        }
    }
}
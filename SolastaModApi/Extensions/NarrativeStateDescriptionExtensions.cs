using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(NarrativeStateDescription))]
    public static partial class NarrativeStateDescriptionExtensions
    {
        public static T SetItemGainDescription<T>(this T entity, ItemGainDescription value)
            where T : NarrativeStateDescription
        {
            entity.SetField("itemGainDescription", value);
            return entity;
        }
    }
}
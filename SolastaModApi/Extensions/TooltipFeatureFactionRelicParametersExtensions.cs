using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(TooltipFeatureFactionRelicParameters))]
    public static class TooltipFeatureFactionRelicParametersExtensions
    {
        public static T SetFactionItemPrefab<T>(this T entity, GameObject value)
            where T : TooltipFeatureFactionRelicParameters
        {
            entity.SetField("factionItemPrefab", value);
            return entity;
        }

        public static T SetFactionItemsTable<T>(this T entity, RectTransform value)
            where T : TooltipFeatureFactionRelicParameters
        {
            entity.SetField("factionItemsTable", value);
            return entity;
        }

        public static T SetVecticalLayoutGroup<T>(this T entity, RectTransform value)
            where T : TooltipFeatureFactionRelicParameters
        {
            entity.SetField("vecticalLayoutGroup", value);
            return entity;
        }
    }
}
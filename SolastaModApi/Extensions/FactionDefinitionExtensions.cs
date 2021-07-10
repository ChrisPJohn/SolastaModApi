using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FactionDefinition))]
    public static partial class FactionDefinitionExtensions
    {
        public static T SetAttackingPenalty<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("attackingPenalty", value);
            return entity;
        }

        public static T SetBuiltIn<T>(this T entity, bool value)
            where T : FactionDefinition
        {
            entity.SetField("builtIn", value);
            return entity;
        }

        public static T SetKillingPenalty<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("killingPenalty", value);
            return entity;
        }

        public static T SetMaxRelationCap<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("maxRelationCap", value);
            return entity;
        }

        public static T SetMinRelationCap<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("minRelationCap", value);
            return entity;
        }

        public static T SetSmallSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : FactionDefinition
        {
            entity.SetField("smallSpriteReference", value);
            return entity;
        }

        public static T SetStealingPenalty<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("stealingPenalty", value);
            return entity;
        }
    }
}
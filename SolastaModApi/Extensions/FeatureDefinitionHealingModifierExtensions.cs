using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionHealingModifier))]
    public static partial class FeatureDefinitionHealingModifierExtensions
    {
        public static T SetAddLevel<T>(this T entity, LevelSourceType value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("addLevel", value);
            return entity;
        }

        public static T SetAdvantageOnHitDieSpending<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("advantageOnHitDieSpending", value);
            return entity;
        }

        public static T SetCannotGainHitPoints<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("cannotGainHitPoints", value);
            return entity;
        }

        public static T SetHealingBonusDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("healingBonusDiceNumber", value);
            return entity;
        }

        public static T SetHealingBonusDiceType<T>(this T entity, DieType value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("healingBonusDiceType", value);
            return entity;
        }

        public static T SetHealingReceivedParticleReference<T>(this T entity, AssetReference value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("healingReceivedParticleReference", value);
            return entity;
        }

        public static T SetHealSelfHealsKindred<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("healSelfHealsKindred", value);
            return entity;
        }

        public static T SetHealsSelfWhenCastingHealingSpell<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("healsSelfWhenCastingHealingSpell", value);
            return entity;
        }

        public static T SetHitDiceHealsKindred<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("hitDiceHealsKindred", value);
            return entity;
        }

        public static T SetMaximizeReceivedHealing<T>(this T entity, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("maximizeReceivedHealing", value);
            return entity;
        }

        public static T SetSelfHealingAddLevel<T>(this T entity, LevelSourceType value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("selfHealingAddLevel", value);
            return entity;
        }

        public static T SetSelfHealingDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("selfHealingDiceNumber", value);
            return entity;
        }

        public static T SetSelfHealingDiceType<T>(this T entity, DieType value)
            where T : FeatureDefinitionHealingModifier
        {
            entity.SetField("selfHealingDiceType", value);
            return entity;
        }
    }
}
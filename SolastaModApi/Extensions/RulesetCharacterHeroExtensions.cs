using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCharacterHero))]
    public static class RulesetCharacterHeroExtensions
    {
        public static T SetAlignmentDefinition<T>(this T entity, AlignmentDefinition value)
            where T : RulesetCharacterHero
        {
            entity.SetField("alignmentDefinition", value);
            return entity;
        }

        public static T SetAttunementCapital<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("attunementCapital", value);
            return entity;
        }

        public static T SetBodyAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterHero
        {
            entity.SetField("bodyAssetPrefix", value);
            return entity;
        }

        public static T SetCharacterClassChanged<T>(this T entity, RulesetCharacterHero.CharacterClassChangedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<CharacterClassChanged>k__BackingField", value);
            return entity;
        }

        public static T SetContextParams<T>(this T entity, RulesetImplementationDefinitions.SituationalContextParams value)
            where T : RulesetCharacterHero
        {
            entity.SetField("contextParams", value);
            return entity;
        }

        public static T SetCriticalFailures<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("criticalFailures", value);
            return entity;
        }

        public static T SetCriticalHits<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("criticalHits", value);
            return entity;
        }

        public static T SetDeviceAutoIdentified<T>(this T entity, RulesetCharacterHero.DeviceAutoIdentifiedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<DeviceAutoIdentified>k__BackingField", value);
            return entity;
        }

        public static T SetDeviceLastChargeUsed<T>(this T entity, RulesetCharacterHero.DeviceLastChargeUsedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<DeviceLastChargeUsed>k__BackingField", value);
            return entity;
        }

        public static T SetEarnedXP<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("earnedXP", value);
            return entity;
        }

        public static T SetExperienceGained<T>(this T entity, RulesetCharacterHero.ExperienceGainedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<ExperienceGained>k__BackingField", value);
            return entity;
        }

        public static T SetFailedAttacks<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("failedAttacks", value);
            return entity;
        }

        public static T SetIgnoreEquipmentOnAbilityScores<T>(this T entity, bool value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<IgnoreEquipmentOnAbilityScores>k__BackingField", value);
            return entity;
        }

        public static T SetInflictedDamage<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("inflictedDamage", value);
            return entity;
        }

        public static T SetItemEquipedCallback<T>(this T entity, RulesetCharacterHero.ItemEquipedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<ItemEquipedCallback>k__BackingField", value);
            return entity;
        }

        public static T SetKnockOuts<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("knockOuts", value);
            return entity;
        }

        public static T SetLastLongRestDay<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("lastLongRestDay", value);
            return entity;
        }

        public static T SetMorphotypeAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterHero
        {
            entity.SetField("morphotypeAssetPrefix", value);
            return entity;
        }

        public static T SetMorphotypeElementAdditionalValueChanged<T>(this T entity, RulesetCharacterHero.MorphotypeElementAdditionalValueChangedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<MorphotypeElementAdditionalValueChanged>k__BackingField", value);
            return entity;
        }

        public static T SetMorphotypeElementChanged<T>(this T entity, RulesetCharacterHero.MorphotypeElementChangedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<MorphotypeElementChanged>k__BackingField", value);
            return entity;
        }

        public static T SetRefreshing<T>(this T entity, bool value)
            where T : RulesetCharacterHero
        {
            entity.SetField("refreshing", value);
            return entity;
        }

        public static T SetRemainingSleepTime<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("remainingSleepTime", value);
            return entity;
        }

        public static T SetRestoredHealth<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("restoredHealth", value);
            return entity;
        }

        public static T SetSlainEnemies<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("slainEnemies", value);
            return entity;
        }

        public static T SetSuccessfulAttacks<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("successfulAttacks", value);
            return entity;
        }

        public static T SetSustainedInjuries<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("sustainedInjuries", value);
            return entity;
        }

        public static T SetTravelledCells<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("travelledCells", value);
            return entity;
        }

        public static T SetTreasury<T>(this T entity, RulesetTreasury value)
            where T : RulesetCharacterHero
        {
            entity.SetField("treasury", value);
            return entity;
        }

        public static T SetUsableDeviceFromMenu<T>(this T entity, RulesetItemDevice value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<UsableDeviceFromMenu>k__BackingField", value);
            return entity;
        }

        public static T SetUsedMagicAndPowers<T>(this T entity, int value)
            where T : RulesetCharacterHero
        {
            entity.SetField("usedMagicAndPowers", value);
            return entity;
        }
    }
}
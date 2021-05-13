using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.42.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCharacterHero))]
    public static class RulesetCharacterHeroExtensions
    {
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

        public static T SetExperienceGained<T>(this T entity, RulesetCharacterHero.ExperienceGainedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<ExperienceGained>k__BackingField", value);
            return entity;
        }

        public static T SetIgnoreEquipmentOnAbilityScores<T>(this T entity, bool value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<IgnoreEquipmentOnAbilityScores>k__BackingField", value);
            return entity;
        }

        public static T SetItemEquipedCallback<T>(this T entity, RulesetCharacterHero.ItemEquipedHandler value)
            where T : RulesetCharacterHero
        {
            entity.SetField("<ItemEquipedCallback>k__BackingField", value);
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
    }
}
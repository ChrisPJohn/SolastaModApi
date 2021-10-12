using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetItem))]
    public static partial class RulesetItemExtensions
    {
        public static T SetAttunedToCharacter<T>(this T entity, string value)
            where T : RulesetItem
        {
            entity.AttunedToCharacter = value;
            return entity;
        }

        public static T SetBearerGuid<T>(this T entity, ulong value)
            where T : RulesetItem
        {
            entity.BearerGuid = value;
            return entity;
        }

        public static T SetDeityMark<T>(this T entity, string value)
            where T : RulesetItem
        {
            entity.DeityMark = value;
            return entity;
        }

        public static T SetGains<T>(this T entity, int[] value)
            where T : RulesetItem
        {
            entity.SetField("gains", value);
            return entity;
        }

        public static T SetIdentified<T>(this T entity, bool value)
            where T : RulesetItem
        {
            entity.Identified = value;
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : RulesetItem
        {
            entity.ItemDefinition = value;
            return entity;
        }

        public static T SetItemDestroyed<T>(this T entity, RulesetItem.ItemDestroyedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemDestroyed>k__BackingField", value);
            return entity;
        }

        public static T SetItemDurationRefreshed<T>(this T entity, RulesetItem.ItemDurationRefreshedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemDurationRefreshed>k__BackingField", value);
            return entity;
        }

        public static T SetItemPropertyRemoved<T>(this T entity, RulesetItem.ItemPropertyRemovedHandler value)
            where T : RulesetItem
        {
            entity.SetField("<ItemPropertyRemoved>k__BackingField", value);
            return entity;
        }

        public static T SetMagicDetected<T>(this T entity, bool value)
            where T : RulesetItem
        {
            entity.MagicDetected = value;
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : RulesetItem
        {
            entity.Name = value;
            return entity;
        }

        public static T SetOwnerName<T>(this T entity, string value)
            where T : RulesetItem
        {
            entity.OwnerName = value;
            return entity;
        }

        public static T SetRulesetLightSource<T>(this T entity, RulesetLightSource value)
            where T : RulesetItem
        {
            entity.RulesetLightSource = value;
            return entity;
        }

        public static T SetSourceSummoningEffectGuid<T>(this T entity, ulong value)
            where T : RulesetItem
        {
            entity.SourceSummoningEffectGuid = value;
            return entity;
        }
    }
}
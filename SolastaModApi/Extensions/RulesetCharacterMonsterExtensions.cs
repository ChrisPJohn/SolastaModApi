using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCharacterMonster))]
    public static partial class RulesetCharacterMonsterExtensions
    {
        public static T SetBodyAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("bodyAssetPrefix", value);
            return entity;
        }

        public static T SetConjuredByParty<T>(this T entity, bool value)
            where T : RulesetCharacterMonster
        {
            entity.ConjuredByParty = value;
            return entity;
        }

        public static T SetCurrentMonsterAttack<T>(this T entity, int value)
            where T : RulesetCharacterMonster
        {
            entity.CurrentMonsterAttack = value;
            return entity;
        }

        public static T SetDroppedLootPackOverride<T>(this T entity, LootPackDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("droppedLootPackOverride", value);
            return entity;
        }

        public static T SetFactionDamagingPenaltyOverride<T>(this T entity, int value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("factionDamagingPenaltyOverride", value);
            return entity;
        }

        public static T SetFactionKillingPenaltyOverride<T>(this T entity, int value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("factionKillingPenaltyOverride", value);
            return entity;
        }

        public static T SetFactionThievingPenaltyOverride<T>(this T entity, int value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("factionThievingPenaltyOverride", value);
            return entity;
        }

        public static T SetHumanoidMonsterPresentationDefinition<T>(this T entity, HumanoidMonsterPresentationDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("humanoidMonsterPresentationDefinition", value);
            return entity;
        }

        public static T SetIsActingLegendarily<T>(this T entity, bool value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("<IsActingLegendarily>k__BackingField", value);
            return entity;
        }

        public static T SetLegendaryActionUsed<T>(this T entity, RulesetCharacterMonster.LegendaryActionUsedHandler value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("<LegendaryActionUsed>k__BackingField", value);
            return entity;
        }

        public static T SetLegendaryResistanceUsed<T>(this T entity, RulesetCharacterMonster.LegendaryResistanceUsedHandler value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("<LegendaryResistanceUsed>k__BackingField", value);
            return entity;
        }

        public static T SetMonsterDefinition<T>(this T entity, MonsterDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("monsterDefinition", value);
            return entity;
        }

        public static T SetMonsterPresentationDefinition<T>(this T entity, MonsterPresentationDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("monsterPresentationDefinition", value);
            return entity;
        }

        public static T SetMorphotypeAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("morphotypeAssetPrefix", value);
            return entity;
        }

        public static T SetPrespawning<T>(this T entity, bool value)
            where T : RulesetCharacterMonster
        {
            entity.Prespawning = value;
            return entity;
        }

        public static T SetPrivateSeed<T>(this T entity, int value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("privateSeed", value);
            return entity;
        }

        public static T SetStealableLootPackOverride<T>(this T entity, LootPackDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("stealableLootPackOverride", value);
            return entity;
        }
    }
}
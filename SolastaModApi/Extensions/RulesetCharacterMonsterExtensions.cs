using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class RulesetCharacterMonsterExtensions
    {
        public static T SetBodyAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("bodyAssetPrefix", value);
            return entity;
        }

        public static T SetDroppedLootPackOverride<T>(this T entity, LootPackDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("droppedLootPackOverride", value);
            return entity;
        }

        public static T SetHumanoidMonsterPresentationDefinition<T>(this T entity, HumanoidMonsterPresentationDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("humanoidMonsterPresentationDefinition", value);
            return entity;
        }

        public static T SetMonsterDefinition<T>(this T entity, MonsterDefinition value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("monsterDefinition", value);
            return entity;
        }

        public static T SetMorphotypeAssetPrefix<T>(this T entity, string value)
            where T : RulesetCharacterMonster
        {
            entity.SetField("morphotypeAssetPrefix", value);
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
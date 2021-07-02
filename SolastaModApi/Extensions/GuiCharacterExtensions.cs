using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiCharacter))]
    public static partial class GuiCharacterExtensions
    {
        public static T SetGameCampaignCharacter<T>(this T entity, GameCampaignCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("gameCampaignCharacter", value);
            return entity;
        }

        public static T SetGameLocationCharacter<T>(this T entity, GameLocationCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("gameLocationCharacter", value);
            return entity;
        }

        public static T SetHealthGaugeDirty<T>(this T entity, bool value)
            where T : GuiCharacter
        {
            entity.SetField("healthGaugeDirty", value);
            return entity;
        }

        public static T SetHealthLabelDirty<T>(this T entity, bool value)
            where T : GuiCharacter
        {
            entity.SetField("healthLabelDirty", value);
            return entity;
        }

        public static T SetLastCharacterLevel<T>(this T entity, int value)
            where T : GuiCharacter
        {
            entity.SetField("lastCharacterLevel", value);
            return entity;
        }

        public static T SetLastCurrentHitPoints<T>(this T entity, int value)
            where T : GuiCharacter
        {
            entity.SetField("lastCurrentHitPoints", value);
            return entity;
        }

        public static T SetLastLevelAndClassAndSubclass<T>(this T entity, string value)
            where T : GuiCharacter
        {
            entity.SetField("lastLevelAndClassAndSubclass", value);
            return entity;
        }

        public static T SetLastMainClassDefinition<T>(this T entity, CharacterClassDefinition value)
            where T : GuiCharacter
        {
            entity.SetField("lastMainClassDefinition", value);
            return entity;
        }

        public static T SetLastMaxHitPoints<T>(this T entity, int value)
            where T : GuiCharacter
        {
            entity.SetField("lastMaxHitPoints", value);
            return entity;
        }

        public static T SetLastSubClassDefinition<T>(this T entity, CharacterSubclassDefinition value)
            where T : GuiCharacter
        {
            entity.SetField("lastSubClassDefinition", value);
            return entity;
        }

        public static T SetLastTemporaryHitPoints<T>(this T entity, int value)
            where T : GuiCharacter
        {
            entity.SetField("lastTemporaryHitPoints", value);
            return entity;
        }

        public static T SetListing<T>(this T entity, string value)
            where T : GuiCharacter
        {
            entity.SetField("listing", value);
            return entity;
        }

        public static T SetMonsterSpriteRef<T>(this T entity, Sprite value)
            where T : GuiCharacter
        {
            entity.SetField("monsterSpriteRef", value);
            return entity;
        }

        public static T SetRulesetCharacter<T>(this T entity, RulesetCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacter", value);
            return entity;
        }

        public static T SetRulesetCharacterEffectProxy<T>(this T entity, RulesetCharacterEffectProxy value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterEffectProxy", value);
            return entity;
        }

        public static T SetRulesetCharacterHero<T>(this T entity, RulesetCharacterHero value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterHero", value);
            return entity;
        }

        public static T SetRulesetCharacterMonster<T>(this T entity, RulesetCharacterMonster value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterMonster", value);
            return entity;
        }

        public static T SetSnapshot<T>(this T entity, RulesetCharacterHero.Snapshot value)
            where T : GuiCharacter
        {
            entity.SetField("snapshot", value);
            return entity;
        }
    }
}
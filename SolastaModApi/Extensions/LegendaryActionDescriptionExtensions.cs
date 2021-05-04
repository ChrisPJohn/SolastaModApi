using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class LegendaryActionDescriptionExtensions
    {
        public static T SetCanMove<T>(this T entity, bool value)
            where T : LegendaryActionDescription
        {
            entity.SetField("canMove", value);
            return entity;
        }

        public static T SetCost<T>(this T entity, int value)
            where T : LegendaryActionDescription
        {
            entity.SetField("cost", value);
            return entity;
        }

        public static T SetDecisionPackage<T>(this T entity, DecisionPackageDefinition value)
            where T : LegendaryActionDescription
        {
            entity.SetField("decisionPackage", value);
            return entity;
        }

        public static T SetFeatureDefinitionPower<T>(this T entity, FeatureDefinitionPower value)
            where T : LegendaryActionDescription
        {
            entity.SetField("featureDefinitionPower", value);
            return entity;
        }

        public static T SetMagicAbilityBonus<T>(this T entity, int value)
            where T : LegendaryActionDescription
        {
            entity.SetField("magicAbilityBonus", value);
            return entity;
        }

        public static T SetMagicAttackBonus<T>(this T entity, int value)
            where T : LegendaryActionDescription
        {
            entity.SetField("magicAttackBonus", value);
            return entity;
        }

        public static T SetMonsterAttackDefinition<T>(this T entity, MonsterAttackDefinition value)
            where T : LegendaryActionDescription
        {
            entity.SetField("monsterAttackDefinition", value);
            return entity;
        }

        public static T SetMoveMode<T>(this T entity, FeatureDefinitionMoveMode value)
            where T : LegendaryActionDescription
        {
            entity.SetField("moveMode", value);
            return entity;
        }

        public static T SetNoOpportunityAttack<T>(this T entity, bool value)
            where T : LegendaryActionDescription
        {
            entity.SetField("noOpportunityAttack", value);
            return entity;
        }

        public static T SetSaveDC<T>(this T entity, int value)
            where T : LegendaryActionDescription
        {
            entity.SetField("saveDC", value);
            return entity;
        }

        public static T SetSpellDefinition<T>(this T entity, SpellDefinition value)
            where T : LegendaryActionDescription
        {
            entity.SetField("spellDefinition", value);
            return entity;
        }

        public static T SetSubaction<T>(this T entity, LegendaryActionDescription.SubactionType value)
            where T : LegendaryActionDescription
        {
            entity.SetField("subaction", value);
            return entity;
        }
    }
}
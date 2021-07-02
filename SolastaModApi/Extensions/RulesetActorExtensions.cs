using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetActor))]
    public static partial class RulesetActorExtensions
    {
        public static T SetAbilityScoreIncreased<T>(this T entity, RulesetActor.AbilityScoreIncreasedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<AbilityScoreIncreased>k__BackingField", value);
            return entity;
        }

        public static T SetActionModifier<T>(this T entity, ActionModifier value)
            where T : RulesetActor
        {
            entity.SetField("actionModifier", value);
            return entity;
        }

        public static T SetAlterationInflicted<T>(this T entity, RulesetActor.AlterationInflictedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<AlterationInflicted>k__BackingField", value);
            return entity;
        }

        public static T SetAttackAutomaticHit<T>(this T entity, RulesetActor.AttackAutomaticHitHandler value)
            where T : RulesetActor
        {
            entity.SetField("<AttackAutomaticHit>k__BackingField", value);
            return entity;
        }

        public static T SetAttackInitiated<T>(this T entity, RulesetActor.AttackInitiatedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<AttackInitiated>k__BackingField", value);
            return entity;
        }

        public static T SetAttackRolled<T>(this T entity, RulesetActor.AttackRolledHandler value)
            where T : RulesetActor
        {
            entity.SetField("<AttackRolled>k__BackingField", value);
            return entity;
        }

        public static T SetConditionAdded<T>(this T entity, RulesetActor.ConditionAddedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ConditionAdded>k__BackingField", value);
            return entity;
        }

        public static T SetConditionOccurenceReached<T>(this T entity, RulesetActor.ConditionOccurenceReachedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ConditionOccurenceReached>k__BackingField", value);
            return entity;
        }

        public static T SetConditionRemoved<T>(this T entity, RulesetActor.ConditionRemovedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ConditionRemoved>k__BackingField", value);
            return entity;
        }

        public static T SetConditionRemovedForVisual<T>(this T entity, RulesetActor.ConditionRemovedForVisualHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ConditionRemovedForVisual>k__BackingField", value);
            return entity;
        }

        public static T SetConditionSaveRerollRequested<T>(this T entity, RulesetActor.ConditionSaveRerollRequestedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ConditionSaveRerollRequested>k__BackingField", value);
            return entity;
        }

        public static T SetDamageAltered<T>(this T entity, RulesetActor.DamageAlteredHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DamageAltered>k__BackingField", value);
            return entity;
        }

        public static T SetDamageFormsTriggered<T>(this T entity, RulesetActor.DamageFormsTriggeredHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DamageFormsTriggered>k__BackingField", value);
            return entity;
        }

        public static T SetDamageHalved<T>(this T entity, RulesetActor.DamageHalvedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DamageHalved>k__BackingField", value);
            return entity;
        }

        public static T SetDamageReceived<T>(this T entity, RulesetActor.DamageReceivedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DamageReceived>k__BackingField", value);
            return entity;
        }

        public static T SetDamageReduced<T>(this T entity, RulesetActor.DamageReducedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DamageReduced>k__BackingField", value);
            return entity;
        }

        public static T SetDieRerolled<T>(this T entity, RulesetActor.DieRerolledHandler value)
            where T : RulesetActor
        {
            entity.SetField("<DieRerolled>k__BackingField", value);
            return entity;
        }

        public static T SetForcedName<T>(this T entity, string value)
            where T : RulesetActor
        {
            entity.SetField("<ForcedName>k__BackingField", value);
            return entity;
        }

        public static T SetHealingFormsTriggered<T>(this T entity, RulesetActor.HealingFormsTriggeredHandler value)
            where T : RulesetActor
        {
            entity.SetField("<HealingFormsTriggered>k__BackingField", value);
            return entity;
        }

        public static T SetImmuneToCondition<T>(this T entity, RulesetActor.ImmuneToConditionHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ImmuneToCondition>k__BackingField", value);
            return entity;
        }

        public static T SetImmuneToDamage<T>(this T entity, RulesetActor.ImmuneToDamageHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ImmuneToDamage>k__BackingField", value);
            return entity;
        }

        public static T SetImmuneToSpell<T>(this T entity, RulesetActor.ImmuneToSpellHandler value)
            where T : RulesetActor
        {
            entity.SetField("<ImmuneToSpell>k__BackingField", value);
            return entity;
        }

        public static T SetIncomingAttackRolled<T>(this T entity, RulesetActor.IncomingAttackRolledHandler value)
            where T : RulesetActor
        {
            entity.SetField("<IncomingAttackRolled>k__BackingField", value);
            return entity;
        }

        public static T SetIncomingDamageNotified<T>(this T entity, RulesetActor.IncomingDamageNotifiedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<IncomingDamageNotified>k__BackingField", value);
            return entity;
        }

        public static T SetPostLoaded<T>(this T entity, bool value)
            where T : RulesetActor
        {
            entity.SetField("<PostLoaded>k__BackingField", value);
            return entity;
        }

        public static T SetSaveRolled<T>(this T entity, RulesetActor.SaveRolledHandler value)
            where T : RulesetActor
        {
            entity.SetField("<SaveRolled>k__BackingField", value);
            return entity;
        }

        public static T SetSide<T>(this T entity, Side value)
            where T : RulesetActor
        {
            entity.SetField("side", value);
            return entity;
        }

        public static T SetSpellDissipated<T>(this T entity, RulesetActor.SpellDissipatedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<SpellDissipated>k__BackingField", value);
            return entity;
        }

        public static T SetTagRevealed<T>(this T entity, RulesetActor.TagRevealedHandler value)
            where T : RulesetActor
        {
            entity.SetField("<TagRevealed>k__BackingField", value);
            return entity;
        }
    }
}
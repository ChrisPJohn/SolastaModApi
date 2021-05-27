using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(RulesetCharacter))]
    public static class RulesetCharacterExtensions
    {
        public static T SetAbilityCheckRolled<T>(this T entity, RulesetCharacter.AbilityCheckRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<AbilityCheckRolled>k__BackingField", value);
            return entity;
        }

        public static T SetActivePowerAdded<T>(this T entity, RulesetCharacter.ActivePowerAddedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ActivePowerAdded>k__BackingField", value);
            return entity;
        }

        public static T SetActiveSpellAdded<T>(this T entity, RulesetCharacter.ActiveSpellAddedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ActiveSpellAdded>k__BackingField", value);
            return entity;
        }

        public static T SetAdditionalDamageGenerated<T>(this T entity, RulesetCharacter.AdditionalDamageGeneratedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<AdditionalDamageGenerated>k__BackingField", value);
            return entity;
        }

        public static T SetAttackOfOpportunity<T>(this T entity, RulesetCharacter.AttackOfOpportunityHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<AttackOfOpportunity>k__BackingField", value);
            return entity;
        }

        public static T SetAutoActivatingPower<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("autoActivatingPower", value);
            return entity;
        }

        public static T SetBaseFaction<T>(this T entity, FactionDefinition value)
            where T : RulesetCharacter
        {
            entity.SetField("baseFaction", value);
            return entity;
        }

        public static T SetBreakFreeExecuted<T>(this T entity, RulesetCharacter.BreakFreeExecutedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<BreakFreeExecuted>k__BackingField", value);
            return entity;
        }

        public static T SetCannotReceiveHealing<T>(this T entity, RulesetCharacter.CannotReceiveHealingHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CannotReceiveHealing>k__BackingField", value);
            return entity;
        }

        public static T SetCarryingSize<T>(this T entity, CreatureSize value)
            where T : RulesetCharacter
        {
            entity.SetField("carryingSize", value);
            return entity;
        }

        public static T SetCharacterControlChanged<T>(this T entity, RulesetCharacter.CharacterControlChangedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharacterControlChanged>k__BackingField", value);
            return entity;
        }

        public static T SetCharacterFactionChanged<T>(this T entity, RulesetCharacter.CharacterFactionChangedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharacterFactionChanged>k__BackingField", value);
            return entity;
        }

        public static T SetCharacterRefreshed<T>(this T entity, RulesetCharacter.CharacterRefreshedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharacterRefreshed>k__BackingField", value);
            return entity;
        }

        public static T SetCharacterRevived<T>(this T entity, RulesetCharacter.CharacterRevivedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharacterRevived>k__BackingField", value);
            return entity;
        }

        public static T SetCharacterWasStolenItems<T>(this T entity, RulesetCharacter.CharacterWasStolenItemsHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharacterWasStolenItems>k__BackingField", value);
            return entity;
        }

        public static T SetCharmedCharacterRemovedFromBattle<T>(this T entity, RulesetCharacter.CharmedCharacterRemovedFromBattleHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CharmedCharacterRemovedFromBattle>k__BackingField", value);
            return entity;
        }

        public static T SetConcentratedSpell<T>(this T entity, RulesetEffectSpell value)
            where T : RulesetCharacter
        {
            entity.SetField("concentratedSpell", value);
            return entity;
        }

        public static T SetConcentratedSpellIndex<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("concentratedSpellIndex", value);
            return entity;
        }

        public static T SetConcentrationChanged<T>(this T entity, RulesetCharacter.ConcentrationChangedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ConcentrationChanged>k__BackingField", value);
            return entity;
        }

        public static T SetConcentrationCheckRolled<T>(this T entity, RulesetCharacter.ConcentrationCheckRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ConcentrationCheckRolled>k__BackingField", value);
            return entity;
        }

        public static T SetConcentrationLost<T>(this T entity, RulesetCharacter.ConcentrationLostHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ConcentrationLost>k__BackingField", value);
            return entity;
        }

        public static T SetContestCheckRolled<T>(this T entity, RulesetCharacter.ContestCheckRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ContestCheckRolled>k__BackingField", value);
            return entity;
        }

        public static T SetCraftingAttempted<T>(this T entity, RulesetCharacter.CraftingAttemptedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CraftingAttempted>k__BackingField", value);
            return entity;
        }

        public static T SetCraftingUpdated<T>(this T entity, RulesetCharacter.CraftingUpdatedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<CraftingUpdated>k__BackingField", value);
            return entity;
        }

        public static T SetDamageRetaliated<T>(this T entity, RulesetCharacter.DamageRetaliatedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DamageRetaliated>k__BackingField", value);
            return entity;
        }

        public static T SetDamageSustained<T>(this T entity, RulesetCharacter.DamageSustainedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DamageSustained>k__BackingField", value);
            return entity;
        }

        public static T SetDeadlyFall<T>(this T entity, RulesetCharacter.DeadlyFallHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DeadlyFall>k__BackingField", value);
            return entity;
        }

        public static T SetDeathSaveFailures<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("deathSaveFailures", value);
            return entity;
        }

        public static T SetDeathSaveRegainLife<T>(this T entity, RulesetCharacter.DeathSaveRegainLifeHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DeathSaveRegainLife>k__BackingField", value);
            return entity;
        }

        public static T SetDeathSaveRolled<T>(this T entity, RulesetCharacter.DeathSaveRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DeathSaveRolled>k__BackingField", value);
            return entity;
        }

        public static T SetDeathSaveSuccesses<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("deathSaveSuccesses", value);
            return entity;
        }

        public static T SetDeathTimerTicked<T>(this T entity, RulesetCharacter.DeathTimerTickedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<DeathTimerTicked>k__BackingField", value);
            return entity;
        }

        public static T SetFactionOverride<T>(this T entity, FactionDefinition value)
            where T : RulesetCharacter
        {
            entity.SetField("factionOverride", value);
            return entity;
        }

        public static T SetForcedBeardShape<T>(this T entity, string value)
            where T : RulesetCharacter
        {
            entity.SetField("<ForcedBeardShape>k__BackingField", value);
            return entity;
        }

        public static T SetHasRegeneration<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("hasRegeneration", value);
            return entity;
        }

        public static T SetHealingFromInflictedDamageReceived<T>(this T entity, RulesetCharacter.HealingFromInflictedDamageReceivedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<HealingFromInflictedDamageReceived>k__BackingField", value);
            return entity;
        }

        public static T SetHealingReceived<T>(this T entity, RulesetCharacter.HealingReceivedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<HealingReceived>k__BackingField", value);
            return entity;
        }

        public static T SetHitDieRolled<T>(this T entity, RulesetCharacter.HitDieRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<HitDieRolled>k__BackingField", value);
            return entity;
        }

        public static T SetHitPointsRegenerated<T>(this T entity, RulesetCharacter.HitPointsRegeneratedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<HitPointsRegenerated>k__BackingField", value);
            return entity;
        }

        public static T SetImpairedSight<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("impairedSight", value);
            return entity;
        }

        public static T SetIndomitableResistanceUsed<T>(this T entity, RulesetCharacter.IndomitableResistanceUsedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<IndomitableResistanceUsed>k__BackingField", value);
            return entity;
        }

        public static T SetInitiativeRolled<T>(this T entity, RulesetCharacter.InitiativeRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<InitiativeRolled>k__BackingField", value);
            return entity;
        }

        public static T SetInitiativeSequenceComplete<T>(this T entity, RulesetCharacter.InitiativeSequenceCompleteHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<InitiativeSequenceComplete>k__BackingField", value);
            return entity;
        }

        public static T SetInstantDeathPrevented<T>(this T entity, RulesetCharacter.InstantDeathPreventedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<InstantDeathPrevented>k__BackingField", value);
            return entity;
        }

        public static T SetIsDead<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isDead", value);
            return entity;
        }

        public static T SetIsDeadOrDying<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isDeadOrDying", value);
            return entity;
        }

        public static T SetIsDeadOrDyingOrUnconscious<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isDeadOrDyingOrUnconscious", value);
            return entity;
        }

        public static T SetIsDeadOrUnconscious<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isDeadOrUnconscious", value);
            return entity;
        }

        public static T SetIsDying<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isDying", value);
            return entity;
        }

        public static T SetIsIncapacitated<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isIncapacitated", value);
            return entity;
        }

        public static T SetIsRemovedFromTheGame<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isRemovedFromTheGame", value);
            return entity;
        }

        public static T SetIsUnconscious<T>(this T entity, bool value)
            where T : RulesetCharacter
        {
            entity.SetField("isUnconscious", value);
            return entity;
        }

        public static T SetItemConsumed<T>(this T entity, RulesetCharacter.ItemConsumedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ItemConsumed>k__BackingField", value);
            return entity;
        }

        public static T SetItemGained<T>(this T entity, RulesetCharacter.ItemGainedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ItemGained>k__BackingField", value);
            return entity;
        }

        public static T SetItemLost<T>(this T entity, RulesetCharacter.ItemGainedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ItemLost>k__BackingField", value);
            return entity;
        }

        public static T SetItemUsed<T>(this T entity, RulesetCharacter.ItemUsedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ItemUsed>k__BackingField", value);
            return entity;
        }

        public static T SetKnockOutPrevented<T>(this T entity, RulesetCharacter.KnockOutPreventedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<KnockOutPrevented>k__BackingField", value);
            return entity;
        }

        public static T SetLastDeathSaveFailed<T>(this T entity, RulesetCharacter.LastDeathSaveFailedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<LastDeathSaveFailed>k__BackingField", value);
            return entity;
        }

        public static T SetLastInitiativeModifier<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("<LastInitiativeModifier>k__BackingField", value);
            return entity;
        }

        public static T SetLastInitiativeRoll<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("<LastInitiativeRoll>k__BackingField", value);
            return entity;
        }

        public static T SetLineOfSightParametersModified<T>(this T entity, RulesetCharacter.LineOfSightParametersModifiedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<LineOfSightParametersModified>k__BackingField", value);
            return entity;
        }

        public static T SetMagicalHitPointsPoolRolled<T>(this T entity, RulesetCharacter.MagicalHitPointsPoolRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<MagicalHitPointsPoolRolled>k__BackingField", value);
            return entity;
        }

        public static T SetMaxClimbRange<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("maxClimbRange", value);
            return entity;
        }

        public static T SetMaxJumpRange<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("maxJumpRange", value);
            return entity;
        }

        public static T SetMaxJumpType<T>(this T entity, RulesetCharacter.JumpRuleType value)
            where T : RulesetCharacter
        {
            entity.SetField("maxJumpType", value);
            return entity;
        }

        public static T SetMaxSenseRange<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("maxSenseRange", value);
            return entity;
        }

        public static T SetMinSizeDifferenceToGoThroughEnemy<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("minSizeDifferenceToGoThroughEnemy", value);
            return entity;
        }

        public static T SetMotionRangeFlags<T>(this T entity, RulesetCharacter.MotionRange value)
            where T : RulesetCharacter
        {
            entity.SetField("motionRangeFlags", value);
            return entity;
        }

        public static T SetOutOfAttackUses<T>(this T entity, RulesetCharacter.OutOfAttackUsesHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<OutOfAttackUses>k__BackingField", value);
            return entity;
        }

        public static T SetOverConcentrationUsed<T>(this T entity, RulesetCharacter.OverConcentrationUsedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<OverConcentrationUsed>k__BackingField", value);
            return entity;
        }

        public static T SetPersonalLightSourceAdded<T>(this T entity, RulesetCharacter.PersonalLightSourceAddedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PersonalLightSourceAdded>k__BackingField", value);
            return entity;
        }

        public static T SetPersonalLightSourceRemoved<T>(this T entity, RulesetCharacter.PersonalLightSourceRemovedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PersonalLightSourceRemoved>k__BackingField", value);
            return entity;
        }

        public static T SetPowerActivated<T>(this T entity, RulesetCharacter.PowerActivatedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PowerActivated>k__BackingField", value);
            return entity;
        }

        public static T SetPowerFailureChecked<T>(this T entity, RulesetCharacter.PowerFailureCheckedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PowerFailureChecked>k__BackingField", value);
            return entity;
        }

        public static T SetPowerRecharged<T>(this T entity, RulesetCharacter.PowerRechargedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PowerRecharged>k__BackingField", value);
            return entity;
        }

        public static T SetPreventedFromActingThisTurn<T>(this T entity, RulesetCharacter.PreventedToActThisTurnHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<PreventedFromActingThisTurn>k__BackingField", value);
            return entity;
        }

        public static T SetRandomBehaviourRolled<T>(this T entity, RulesetCharacter.RandomBehaviourRolledHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<RandomBehaviourRolled>k__BackingField", value);
            return entity;
        }

        public static T SetRegenerationLapse<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("regenerationLapse", value);
            return entity;
        }

        public static T SetRemovedFromTheGameStarted<T>(this T entity, RulesetCharacter.RemovedFromTheGameStartedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<RemovedFromTheGameStarted>k__BackingField", value);
            return entity;
        }

        public static T SetRemovedFromTheGameStopped<T>(this T entity, RulesetCharacter.RemovedFromTheGameStoppedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<RemovedFromTheGameStopped>k__BackingField", value);
            return entity;
        }

        public static T SetReviveFailed<T>(this T entity, RulesetCharacter.ReviveFailedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<ReviveFailed>k__BackingField", value);
            return entity;
        }

        public static T SetRitualCast<T>(this T entity, RulesetCharacter.RitualCastHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<RitualCast>k__BackingField", value);
            return entity;
        }

        public static T SetSpellCast<T>(this T entity, RulesetCharacter.SpellCastHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellCast>k__BackingField", value);
            return entity;
        }

        public static T SetSpellcastingFailed<T>(this T entity, RulesetCharacter.SpellcastingFailedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellcastingFailed>k__BackingField", value);
            return entity;
        }

        public static T SetSpellComponentConsumed<T>(this T entity, RulesetCharacter.SpellComponentConsumedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellComponentConsumed>k__BackingField", value);
            return entity;
        }

        public static T SetSpellCounter<T>(this T entity, RulesetCharacter.SpellCounterHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellCounter>k__BackingField", value);
            return entity;
        }

        public static T SetSpellCounterAttack<T>(this T entity, RulesetCharacter.SpellCounterAttackHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellCounterAttack>k__BackingField", value);
            return entity;
        }

        public static T SetSpellIdentified<T>(this T entity, RulesetCharacter.SpellIdentifiedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellIdentified>k__BackingField", value);
            return entity;
        }

        public static T SetSpellMissingComponent<T>(this T entity, RulesetCharacter.SpellMissingComponentHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellMissingComponent>k__BackingField", value);
            return entity;
        }

        public static T SetSpellRepertoireSlotsRecovered<T>(this T entity, RulesetCharacter.SpellRepertoireSlotsRecoveredHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellRepertoireSlotsRecovered>k__BackingField", value);
            return entity;
        }

        public static T SetSpellScribed<T>(this T entity, RulesetCharacter.SpellScribedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<SpellScribed>k__BackingField", value);
            return entity;
        }

        public static T SetTemporaryHitPointsReceived<T>(this T entity, RulesetCharacter.TemporaryHitPointsReceivedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<TemporaryHitPointsReceived>k__BackingField", value);
            return entity;
        }

        public static T SetTimeOfDeath<T>(this T entity, int value)
            where T : RulesetCharacter
        {
            entity.SetField("timeOfDeath", value);
            return entity;
        }

        public static T SetTurnSkipped<T>(this T entity, RulesetCharacter.TurnSkippedHandler value)
            where T : RulesetCharacter
        {
            entity.SetField("<TurnSkipped>k__BackingField", value);
            return entity;
        }

        public static T SetVisionHeight<T>(this T entity, float value)
            where T : RulesetCharacter
        {
            entity.SetField("visionHeight", value);
            return entity;
        }

        public static T SetVisionHeightFactor<T>(this T entity, float value)
            where T : RulesetCharacter
        {
            entity.SetField("visionHeightFactor", value);
            return entity;
        }

        public static T SetWieldingSize<T>(this T entity, CreatureSize value)
            where T : RulesetCharacter
        {
            entity.SetField("wieldingSize", value);
            return entity;
        }
    }
}
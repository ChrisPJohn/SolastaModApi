using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(EffectForm))]
    public static partial class EffectFormExtensions
    {
        public static T SetAddBonusMode<T>(this T entity, AddBonusMode value)
            where T : EffectForm
        {
            entity.AddBonusMode = value;
            return entity;
        }

        public static T SetAlterationForm<T>(this T entity, AlterationForm value)
            where T : EffectForm
        {
            entity.SetField("alterationForm", value);
            return entity;
        }

        public static T SetApplyLevel<T>(this T entity, EffectForm.LevelApplianceType value)
            where T : EffectForm
        {
            entity.SetField("applyLevel", value);
            return entity;
        }

        public static T SetCanSaveToCancel<T>(this T entity, bool value)
            where T : EffectForm
        {
            entity.CanSaveToCancel = value;
            return entity;
        }

        public static T SetConditionForm<T>(this T entity, ConditionForm value)
            where T : EffectForm
        {
            entity.ConditionForm = value;
            return entity;
        }

        public static T SetCounterForm<T>(this T entity, CounterForm value)
            where T : EffectForm
        {
            entity.SetField("counterForm", value);
            return entity;
        }

        public static T SetCreatedByCharacter<T>(this T entity, bool value)
            where T : EffectForm
        {
            entity.SetField("createdByCharacter", value);
            return entity;
        }

        public static T SetCreatedByCondition<T>(this T entity, bool value)
            where T : EffectForm
        {
            entity.SetField("createdByCondition", value);
            return entity;
        }

        public static T SetDamageForm<T>(this T entity, DamageForm value)
            where T : EffectForm
        {
            entity.DamageForm = value;
            return entity;
        }

        public static T SetDivinationForm<T>(this T entity, DivinationForm value)
            where T : EffectForm
        {
            entity.SetField("divinationForm", value);
            return entity;
        }

        public static T SetFormType<T>(this T entity, EffectForm.EffectFormType value)
            where T : EffectForm
        {
            entity.FormType = value;
            return entity;
        }

        public static T SetHasSavingThrow<T>(this T entity, bool value)
            where T : EffectForm
        {
            entity.HasSavingThrow = value;
            return entity;
        }

        public static T SetHealingForm<T>(this T entity, HealingForm value)
            where T : EffectForm
        {
            entity.SetField("healingForm", value);
            return entity;
        }

        public static T SetItemPropertyForm<T>(this T entity, ItemPropertyForm value)
            where T : EffectForm
        {
            entity.SetField("itemPropertyForm", value);
            return entity;
        }

        public static T SetKillForm<T>(this T entity, KillForm value)
            where T : EffectForm
        {
            entity.SetField("killForm", value);
            return entity;
        }

        public static T SetLevelMultiplier<T>(this T entity, int value)
            where T : EffectForm
        {
            entity.SetField("levelMultiplier", value);
            return entity;
        }

        public static T SetLevelType<T>(this T entity, LevelSourceType value)
            where T : EffectForm
        {
            entity.SetField("levelType", value);
            return entity;
        }

        public static T SetLightSourceForm<T>(this T entity, LightSourceForm value)
            where T : EffectForm
        {
            entity.SetField("lightSourceForm", value);
            return entity;
        }

        public static T SetMotionForm<T>(this T entity, MotionForm value)
            where T : EffectForm
        {
            entity.SetField("motionForm", value);
            return entity;
        }

        public static T SetOverrideSavingThrowInfo<T>(this T entity, OverrideSavingThrowInfo value)
            where T : EffectForm
        {
            entity.SetField("<OverrideSavingThrowInfo>k__BackingField", value);
            return entity;
        }

        public static T SetReviveForm<T>(this T entity, ReviveForm value)
            where T : EffectForm
        {
            entity.SetField("reviveForm", value);
            return entity;
        }

        public static T SetSaveOccurence<T>(this T entity, TurnOccurenceType value)
            where T : EffectForm
        {
            entity.SaveOccurence = value;
            return entity;
        }

        public static T SetSavingThrowAffinity<T>(this T entity, EffectSavingThrowType value)
            where T : EffectForm
        {
            entity.SavingThrowAffinity = value;
            return entity;
        }

        public static T SetShapeChangeForm<T>(this T entity, ShapeChangeForm value)
            where T : EffectForm
        {
            entity.SetField("shapeChangeForm", value);
            return entity;
        }

        public static T SetSpellSlotsForm<T>(this T entity, SpellSlotsForm value)
            where T : EffectForm
        {
            entity.SetField("spellSlotsForm", value);
            return entity;
        }

        public static T SetSummonForm<T>(this T entity, SummonForm value)
            where T : EffectForm
        {
            entity.SetField("summonForm", value);
            return entity;
        }

        public static T SetTemporaryHitPointsForm<T>(this T entity, TemporaryHitPointsForm value)
            where T : EffectForm
        {
            entity.SetField("temporaryHitPointsForm", value);
            return entity;
        }

        public static T SetTopologyForm<T>(this T entity, TopologyForm value)
            where T : EffectForm
        {
            entity.SetField("topologyForm", value);
            return entity;
        }
    }
}
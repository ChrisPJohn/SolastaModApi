using SolastaModApi.Diagnostics;
using SolastaModApi.Infrastructure;
using SolastaTesting.SolastaModApi;
using System;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    ///     Base class builder for all classes derived from BaseDefinition
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseDefinitionBuilder<T> where T : BaseDefinition
    {
        /// <summary>
        /// Create a new one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="guid"></param>
        protected BaseDefinitionBuilder(string name, string guid)
        {
            Preconditions.IsNotNullOrWhiteSpace(name, nameof(name));
            Preconditions.IsNotNullOrWhiteSpace(guid, nameof(guid));

            Definition = ScriptableObject.CreateInstance<T>();

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Create a new one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="guidNamespace"></param>
        protected BaseDefinitionBuilder(string name, Guid guidNamespace) :
            this(name, GuidHelper.Create(guidNamespace, name).ToString("N"))
        {
        }

        /// <summary>
        /// Create clone and rename
        /// </summary>
        /// <param name="original"></param>
        /// <param name="name"></param>
        /// <param name="guid"></param>
        protected BaseDefinitionBuilder(T original, string name, string guid)
        {
            Preconditions.IsNotNullOrWhiteSpace(name, nameof(name));
            Preconditions.IsNotNullOrWhiteSpace(guid, nameof(guid));

            Definition = UnityEngine.Object.Instantiate(original);

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Create clone and rename
        /// </summary>
        /// <param name="original"></param>
        /// <param name="name"></param>
        /// <param name="guidNamespace"></param>
        protected BaseDefinitionBuilder(T original, string name, Guid guidNamespace) :
            this(original, name, GuidHelper.Create(guidNamespace, name).ToString("N"))
        {
        }

        /// <summary>
        /// Take ownership
        /// </summary>
        /// <param name="original"></param>
        protected BaseDefinitionBuilder(T original)
        {
            Definition = original;
        }

        private static void AddToDB<TDb>(TDb definition, bool assertIfDuplicate = true) where TDb : BaseDefinition
        {
            Preconditions.IsNotNull(definition, nameof(definition));
            Preconditions.IsNotNullOrWhiteSpace(definition.Name, "definition.Name");
            Preconditions.IsNotNullOrWhiteSpace(definition.GUID, "definition.GUID");

            var db = DatabaseRepository.GetDatabase<TDb>();

            Assert.IsNotNull(db, $"Database '{typeof(TDb).Name}' not found.");

            if (assertIfDuplicate && (db.HasElement(definition.name) || db.HasElementByGuid(definition.GUID)))
                throw new SolastaModApiException(
                    $"The definition with name '{definition.name}' already exists in database '{typeof(TDb)}'");

            db.Add(definition);
        }

        private void AddToDB<TDb>(bool assertIfDuplicate = true)
            where TDb : BaseDefinition
        {
            if(Definition is TDb)
            {
                AddToDB(Definition as TDb, assertIfDuplicate);
            }
        }

        public T AddToDB(bool assertIfDuplicate = true)
        {
            if (Definition is RecordTableDefinition)
            {
                AddToDB<RecordTableDefinition>(assertIfDuplicate);
                AddToDB<AdventureLogDefinition>(assertIfDuplicate);
                AddToDB<BestiaryStatsDefinition>(assertIfDuplicate);
                AddToDB<BestiaryTableDefinition>(assertIfDuplicate);
                AddToDB<ConsoleTableDefinition>(assertIfDuplicate);
                AddToDB<DailyLogDefinition>(assertIfDuplicate);
                AddToDB<DocumentTableDefinition>(assertIfDuplicate);
                AddToDB<TravelJournalDefinition>(assertIfDuplicate);
                AddToDB<TutorialTableDefinition>(assertIfDuplicate);
                AddToDB<TutorialTocDefinition>(assertIfDuplicate);
            }
            else if (Definition is FeatureDefinition)
            {
                AddToDB<FeatureDefinition>(assertIfDuplicate);
                AddToDB<FeatureDefinitionActionAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAdditionalAction>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAdditionalDamage>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAttributeModifier>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAutoPreparedSpells>(assertIfDuplicate);
                AddToDB<FeatureDefinitionBonusCantrips>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCastSpell>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCharacterPresentation>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCriticalCharacter>(assertIfDuplicate);
                AddToDB<FeatureDefinitionFactionAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionFactionChange>(assertIfDuplicate);
                AddToDB<FeatureDefinitionFeatureSet>(assertIfDuplicate);
                AddToDB<FeatureDefinitionFightingStyleChoice>(assertIfDuplicate);
                AddToDB<FeatureDefinitionLightSource>(assertIfDuplicate);
                AddToDB<FeatureDefinitionLoreExpertise>(assertIfDuplicate);
                AddToDB<FeatureDefinitionMovementAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionMoveMode>(assertIfDuplicate);
                AddToDB<FeatureDefinitionPointPool>(assertIfDuplicate);
                AddToDB<FeatureDefinitionPower>(assertIfDuplicate);
                AddToDB<FeatureDefinitionProficiency>(assertIfDuplicate);
                AddToDB<FeatureDefinitionSchoolSavant>(assertIfDuplicate);
                AddToDB<FeatureDefinitionSense>(assertIfDuplicate);
                AddToDB<FeatureDefinitionSocialAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionSubclassChoice>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAbilityCheckAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionAttackModifier>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCampAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCombatAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionConditionAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionCraftingAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionDamageAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionDeathSavingThrowAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionDieRollModifier>(assertIfDuplicate);
                AddToDB<FeatureDefinitionEquipmentAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionHealingModifier>(assertIfDuplicate);
                AddToDB<FeatureDefinitionLanguageAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionLightAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionMagicAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionMoveThroughEnemyModifier>(assertIfDuplicate);
                AddToDB<FeatureDefinitionPerceptionAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionRegeneration>(assertIfDuplicate);
                AddToDB<FeatureDefinitionSavingThrowAffinity>(assertIfDuplicate);
                AddToDB<FeatureDefinitionTerrainTypeAffinity>(assertIfDuplicate);
            }
            else if (Definition is BaseBlueprint)
            {
                AddToDB<BaseBlueprint>(assertIfDuplicate);
                AddToDB<FurnitureBlueprint>(assertIfDuplicate);
                AddToDB<RoomBlueprint>(assertIfDuplicate);
                AddToDB<GadgetBlueprint>(assertIfDuplicate);
                AddToDB<PropBlueprint>(assertIfDuplicate);
            }
            else if (Definition is EditableGraphDefinition)
            {
                AddToDB<EditableGraphDefinition>(assertIfDuplicate);
                AddToDB<NarrativeTreeDefinition>(assertIfDuplicate);
                AddToDB<QuestTreeDefinition>(assertIfDuplicate);
            }
            else
            {
                AddToDB(Definition, assertIfDuplicate);
            }

            return Definition;
        }

        protected T Definition { get; }
    }
}
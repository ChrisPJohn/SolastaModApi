using SolastaModApi.Diagnostics;
using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    ///     Base class builder for all classes derived from BaseDefinition
    /// </summary>
    /// <typeparam name="TDefinition"></typeparam>
    public abstract class BaseDefinitionBuilder<TDefinition> where TDefinition : BaseDefinition
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

            Definition = ScriptableObject.CreateInstance<TDefinition>();

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Create clone and rename
        /// </summary>
        /// <param name="original"></param>
        /// <param name="name"></param>
        /// <param name="guid"></param>
        protected BaseDefinitionBuilder(TDefinition original, string name, string guid)
        {
            Preconditions.IsNotNullOrWhiteSpace(name, nameof(name));
            Preconditions.IsNotNullOrWhiteSpace(guid, nameof(guid));

            Definition = UnityEngine.Object.Instantiate(original);

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Take ownership
        /// </summary>
        /// <param name="original"></param>
        protected BaseDefinitionBuilder(TDefinition original)
        {
            Definition = original;
        }

        private static void AddToDB<TDatabase>(TDatabase definition, bool assertIfDuplicate = true) where TDatabase : BaseDefinition
        {
            Preconditions.IsNotNull(definition, nameof(definition));
            Preconditions.IsNotNullOrWhiteSpace(definition.Name, "definition.Name");
            Preconditions.IsNotNullOrWhiteSpace(definition.GUID, "definition.GUID");

            var db = DatabaseRepository.GetDatabase<TDatabase>();

            Assert.IsNotNull(db, $"Database '{typeof(TDatabase).Name}' not found.");

            if (assertIfDuplicate)
            {
                if (db.HasElement(definition.name))
                {
                    throw new SolastaModApiException(
                        $"The definition with name '{definition.name}' already exists in database '{typeof(TDatabase).Name}' by name.");
                }

                if (db.HasElementByGuid(definition.GUID))
                {
                    throw new SolastaModApiException(
                        $"The definition with name '{definition.name}' and guid '{definition.GUID}' already exists in database '{typeof(TDatabase).Name}' by GUID.");
                }
            }

            db.Add(definition);
        }

        /// <summary>
        /// Some types are added to multiple databases.  For example:
        /// FeatureDefinitionAbilityCheckAffinity is a FeatureDefinitionAffinity is a FeatureDefinition
        /// so an instance of FeatureDefinitionAbilityCheckAffinity should be added to these three databases.
        /// </summary>
        /// <typeparam name="TDatabase"></typeparam>
        /// <param name="assertIfDuplicate"></param>
        private void AddToDBIfMatch<TDatabase>(bool assertIfDuplicate = true)
            where TDatabase : BaseDefinition
        {
            if(Definition is TDatabase)
            {
                AddToDB(Definition as TDatabase, assertIfDuplicate);
            }
        }

        public TDefinition AddToDB(bool assertIfDuplicate = true)
        {
            if (Definition is RecordTableDefinition)
            {
                AddToDBIfMatch<RecordTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<AdventureLogDefinition>(assertIfDuplicate);
                AddToDBIfMatch<BestiaryStatsDefinition>(assertIfDuplicate);
                AddToDBIfMatch<BestiaryTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<ConsoleTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<DailyLogDefinition>(assertIfDuplicate);
                AddToDBIfMatch<DocumentTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TravelJournalDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TutorialTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TutorialTocDefinition>(assertIfDuplicate);
            }
            else if (Definition is FeatureDefinition)
            {
                AddToDBIfMatch<FeatureDefinition>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionActionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAdditionalAction>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAdditionalDamage>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAttributeModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAutoPreparedSpells>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionBonusCantrips>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCastSpell>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCharacterPresentation>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCriticalCharacter>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFactionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFactionChange>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFeatureSet>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFightingStyleChoice>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLightSource>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLoreExpertise>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMovementAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMoveMode>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPointPool>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPower>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionProficiency>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSchoolSavant>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSense>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSocialAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSubclassChoice>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAbilityCheckAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAttackModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCampAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCombatAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionConditionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCraftingAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDamageAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDeathSavingThrowAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDieRollModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionEquipmentAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionHealingModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLanguageAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLightAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMagicAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMoveThroughEnemyModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPerceptionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionRegeneration>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSavingThrowAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionTerrainTypeAffinity>(assertIfDuplicate);
            }
            else if (Definition is SpellDefinition)
            {
                AddToDB<SpellDefinition>(Definition as SpellDefinition, assertIfDuplicate);
            }
            else if (Definition is BaseBlueprint)
            {
                AddToDBIfMatch<BaseBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<FurnitureBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<RoomBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<GadgetBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<PropBlueprint>(assertIfDuplicate);
            }
            else if (Definition is EditableGraphDefinition)
            {
                AddToDBIfMatch<EditableGraphDefinition>(assertIfDuplicate);
                AddToDBIfMatch<NarrativeTreeDefinition>(assertIfDuplicate);
                AddToDBIfMatch<QuestTreeDefinition>(assertIfDuplicate);
            }
            else
            {
                AddToDB(Definition, assertIfDuplicate);
            }

            return Definition;
        }

        protected TDefinition Definition { get; }
    }
}
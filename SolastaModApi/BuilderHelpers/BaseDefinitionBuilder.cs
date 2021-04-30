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

        public T AddToDB(bool assertIfDuplicate = true)
        {
            if(Definition is RecordTableDefinition)
            {
                AddToDB(Definition as RecordTableDefinition, assertIfDuplicate);
            }
            else if (Definition is FeatureDefinitionAffinity)
            {
                AddToDB(Definition as FeatureDefinitionAffinity, assertIfDuplicate);
                AddToDB(Definition as FeatureDefinition, assertIfDuplicate);
            }
            else if (Definition is FeatureDefinition)
            {
                AddToDB(Definition as FeatureDefinition, assertIfDuplicate);
            }
            else if(Definition is FurnitureBlueprint)
            {
                AddToDB(Definition as FurnitureBlueprint, assertIfDuplicate);
                AddToDB(Definition as BaseBlueprint, assertIfDuplicate);
            }
            else if(Definition is BaseBlueprint)
            {
                AddToDB(Definition as BaseBlueprint, assertIfDuplicate);
            }
            else if(Definition is EditableGraphDefinition)
            {
                AddToDB(Definition as EditableGraphDefinition, assertIfDuplicate);
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
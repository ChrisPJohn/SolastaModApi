using SolastaModApi.Diagnostics;

namespace SolastaModApi
{
    /// <summary>
    /// Helpers for getting a definition from a database repository
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// Advanced usage.  Specify the database type and the element type.
        /// This is because TA store the same definition in several databases.
        /// Normally just use GetByGuid with the definition type.
        /// TODO: code examples - pain to do in XML comments.
        /// </summary>
        /// <typeparam name="TDatabase"></typeparam>
        /// <typeparam name="TDefinition"></typeparam>
        /// <param name="name">The name of the definition.</param>
        /// <param name="guid">The guid of the definition.</param>
        /// <param name="throwIfNotFound">Throw an exception if the definition can't be found.</param>
        /// <remarks>
        /// If you supply both name and guid the definition first looked for using the name and then using the guid.</remarks>
        /// <returns></returns>
        public static TDefinition Get<TDatabase, TDefinition>(string name, string guid, bool throwIfNotFound = false)
            where TDatabase : BaseDefinition
            where TDefinition : BaseDefinition
        {
            var db = DatabaseRepository.GetDatabase<TDatabase>();

            if (db == null)
            {
                throw new SolastaModApiException($"Database '{typeof(TDatabase).Name}' not found.");
            }

            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(guid))
            {
                throw new SolastaModApiException($"Please supply a name and/or guid.");
            }

            if (throwIfNotFound)
            {
                if (!string.IsNullOrWhiteSpace(name) && !db.HasElement(name))
                {
                    throw new SolastaModApiException($"A definition with key='{name} was not found in db='{typeof(TDatabase).Name}'.");
                }

                if (!string.IsNullOrWhiteSpace(guid) && !db.HasElementByGuid(guid))
                {
                    throw new SolastaModApiException($"A definition with guid='{guid} was not found in db='{typeof(TDatabase).Name}'.");
                }
            }

            // Get element of type TDatabase
            var element = db.TryGetElement(name, guid);

            if (element == null && throwIfNotFound)
            {
                throw new SolastaModApiException($"A definition with key='{name}' or guid='{guid}' was not found in db='{typeof(TDatabase).Name}'.");
            }

            // Cast to TDefinition
            var definition = element as TDefinition;

            if (definition == null && throwIfNotFound)
            {
                throw new SolastaModApiException($"A definition with key='{name}' or guid='{guid}' was found in db='{typeof(TDatabase).Name}' but is not of type '{typeof(TDefinition).Name}'.");
            }

            return definition;
        }

        /// <summary>
        /// Normal usage.  Specify the definition type, the name and a specific guid.
        /// If the definition exists by name that is returned.  
        /// If the definition doesn't exist by name but does by guid, then that is returned.
        /// </summary>
        public static TDefinition Get<TDefinition>(string name, string guid, bool throwIfNotFound = false)
            where TDefinition : BaseDefinition
        {
            // We need to declare an instance of TDefinition so we can filter by type.
            var t = default(TDefinition);

            // now direct to the correct database
            if (t is RecordTableDefinition)
            {
                return Get<RecordTableDefinition, TDefinition>(name, guid, throwIfNotFound);
            }
            else if (t is FeatureDefinition)
            {
                return Get<FeatureDefinition, TDefinition>(name, guid, throwIfNotFound);
            }
            else if (t is BaseBlueprint)
            {
                return Get<BaseBlueprint, TDefinition>(name, guid, throwIfNotFound);
            }
            else if (t is EditableGraphDefinition)
            {
                return Get<EditableGraphDefinition, TDefinition>(name, guid, throwIfNotFound);
            }
            else if (t is SpellDefinition)
            {
                return Get<SpellDefinition, TDefinition>(name, guid, throwIfNotFound);
            }

            return Get<TDefinition, TDefinition>(name, guid, throwIfNotFound);
        }

        /// <summary>
        /// Get definition by name.  
        /// </summary>
        public static TDefinition GetByName<TDefinition>(string name, bool throwIfNotFound = false)
            where TDefinition : BaseDefinition
        {
            return Get<TDefinition>(name, null, throwIfNotFound);
        }

        /// <summary>
        /// Get definition by Guid.  This is the recommended method to use.
        /// </summary>
        public static TDefinition GetByGuid<TDefinition>(string guid, bool throwIfNotFound = false)
            where TDefinition : BaseDefinition
        {
            return Get<TDefinition>(null, guid, throwIfNotFound);
        }
    }
}
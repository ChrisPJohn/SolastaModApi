using SolastaModApi.Diagnostics;
using System;

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
        /// Normally just use Get with the definition type.
        /// TODO: code examples - pain to do in XML comments.
        /// </summary>
        /// <typeparam name="TDatabase"></typeparam>
        /// <typeparam name="TDefinition"></typeparam>
        /// <param name="name">The name of the definition.</param>
        /// <param name="guid">The guid of the definition.</param>
        /// <param name="throwIfNotFound">Throw an exception if the definition can't be found.</param>
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

            var element = db.TryGetElement(name, guid);

            if (element == null)
            {
                if (throwIfNotFound)
                {
                    throw new SolastaModApiException($"A definition with key='{name} and guid='{guid}' was not found in db='{typeof(TDatabase).Name}'.");
                }

                return null;
            }

            var retval = element as TDefinition;

            if(retval == null)
            {
                if (throwIfNotFound)
                {
                    throw new SolastaModApiException($"A definition with key='{name}' and guid='{guid}' was found in db='{typeof(TDatabase).Name}' but is not of type '{typeof(TDefinition).Name}'.");
                }
            }

            return retval;
        }

        /// <summary>
        /// Advanced usage.  Specify the database type and the element type.
        /// This is because TA store the same definition in several databases.
        /// Normally just use Get with the definition type.
        /// TODO: code examples - pain to do in XML comments.
        /// </summary>
        /// <typeparam name="TDatabase"></typeparam>
        /// <typeparam name="TDefinition"></typeparam>
        /// <param name="name">The name of the definition.</param>
        /// <param name="guidNamespace">The mod namespace guid. The definition guid is derived from this and the name parameter.</param>
        /// <param name="throwIfNotFound">Throw an exception if the definition can't be found.</param>
        /// <returns></returns>
        public static TDefinition Get<TDatabase, TDefinition>(string name, Guid guidNamespace, bool throwIfNotFound = false)
            where TDatabase : BaseDefinition
            where TDefinition : BaseDefinition
        {
            return Get<TDatabase, TDefinition>(name, GuidHelper.Create(guidNamespace, name).ToString("N"), throwIfNotFound);
        }

        /// <summary>
        /// Normal usage.  Specify the definition type, the name and the mod namespace guid.
        /// </summary>
        public static TDefinition Get<TDefinition>(string name, Guid guidNamespace, bool throwIfNotFound = false) 
            where TDefinition : BaseDefinition
        {
            return Get<TDefinition>(name, GuidHelper.Create(guidNamespace, name).ToString("N"), throwIfNotFound);
        }

        /// <summary>
        /// Normal usage.  Specify the definition type, the name and a specific guid.
        /// </summary>
        public static TDefinition Get<TDefinition>(string name, string guid, bool throwIfNotFound = false)
            where TDefinition : BaseDefinition
        {
            // We need to declare an instance of TDefinition so we can filter by type.
            var t = default(TDefinition);

            // now direct to the correct database
            if(t is RecordTableDefinition)
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
            
            return Get<TDefinition, TDefinition>(name, guid, throwIfNotFound);
        }
    }
}
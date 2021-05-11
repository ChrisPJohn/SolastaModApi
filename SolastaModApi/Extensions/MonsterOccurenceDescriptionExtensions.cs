using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MonsterOccurenceDescription))]
    public static class MonsterOccurenceDescriptionExtensions
    {
        public static T SetCreatureSex<T>(this T entity, GadgetDefinitions.CreatureSex value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("creatureSex", value);
            return entity;
        }

        public static T SetEncounterPlacementDecision<T>(this T entity, DecisionPackageDefinition value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("encounterPlacementDecision", value);
            return entity;
        }

        public static T SetFactionName<T>(this T entity, string value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("factionName", value);
            return entity;
        }

        public static T SetMonsterDefinition<T>(this T entity, MonsterDefinition value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("monsterDefinition", value);
            return entity;
        }

        public static T SetNumber<T>(this T entity, int value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("number", value);
            return entity;
        }

        public static T SetOverrideFaction<T>(this T entity, bool value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("overrideFaction", value);
            return entity;
        }

        public static T SetPresentationDefinitionIndex<T>(this T entity, int value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("presentationDefinitionIndex", value);
            return entity;
        }

        public static T SetRandomHumanoidPresentation<T>(this T entity, bool value)
            where T : MonsterOccurenceDescription
        {
            entity.SetField("randomHumanoidPresentation", value);
            return entity;
        }
    }
}
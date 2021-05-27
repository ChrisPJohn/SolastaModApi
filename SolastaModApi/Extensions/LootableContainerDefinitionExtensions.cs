using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(LootableContainerDefinition))]
    public static class LootableContainerDefinitionExtensions
    {
        public static T SetContentAlwaysKnown<T>(this T entity, bool value)
            where T : LootableContainerDefinition
        {
            entity.SetField("contentAlwaysKnown", value);
            return entity;
        }

        public static T SetForbidDrop<T>(this T entity, bool value)
            where T : LootableContainerDefinition
        {
            entity.SetField("forbidDrop", value);
            return entity;
        }

        public static T SetIgnoredByScavengers<T>(this T entity, bool value)
            where T : LootableContainerDefinition
        {
            entity.SetField("ignoredByScavengers", value);
            return entity;
        }

        public static T SetMinSlotsNumber<T>(this T entity, int value)
            where T : LootableContainerDefinition
        {
            entity.SetField("minSlotsNumber", value);
            return entity;
        }
    }
}
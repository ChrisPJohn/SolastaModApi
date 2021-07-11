using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(DialogCharacterTeleportDescription))]
    public static partial class DialogCharacterTeleportDescriptionExtensions
    {
        public static T SetNpcMarkerIndex<T>(this T entity, int value)
            where T : DialogCharacterTeleportDescription
        {
            entity.NpcMarkerIndex = value;
            return entity;
        }

        public static T SetPlayerMarkerIndex<T>(this T entity, int value)
            where T : DialogCharacterTeleportDescription
        {
            entity.PlayerMarkerIndex = value;
            return entity;
        }

        public static T SetRole<T>(this T entity, string value)
            where T : DialogCharacterTeleportDescription
        {
            entity.Role = value;
            return entity;
        }
    }
}
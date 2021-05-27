using SolastaModApi.Infrastructure;
using AK.Wwise;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MusicalStateDefinition))]
    public static class MusicalStateDefinitionExtensions
    {
        public static T SetAudioStateLocation<T>(this T entity, State value)
            where T : MusicalStateDefinition
        {
            entity.SetField("audioStateLocation", value);
            return entity;
        }

        public static T SetAudioStateZone<T>(this T entity, State value)
            where T : MusicalStateDefinition
        {
            entity.SetField("audioStateZone", value);
            return entity;
        }
    }
}
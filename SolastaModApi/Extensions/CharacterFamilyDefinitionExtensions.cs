using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class CharacterFamilyDefinitionExtensions
    {
        public static T SetExtraplanar<T>(this T entity, bool value)
            where T : CharacterFamilyDefinition
        {
            entity.SetField("extraplanar", value);
            return entity;
        }
    }
}
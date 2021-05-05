using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiEnvironmentEffectDefinitionExtensions
    {
        public static T SetEnvironmentEffectDefinition<T>(this T entity, EnvironmentEffectDefinition value)
            where T : GuiEnvironmentEffectDefinition
        {
            entity.SetField("<EnvironmentEffectDefinition>k__BackingField", value);
            return entity;
        }
    }
}
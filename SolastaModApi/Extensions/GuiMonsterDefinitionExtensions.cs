using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiMonsterDefinitionExtensions
    {
        public static T SetMonsterDefinition<T>(this T entity, MonsterDefinition value)
            where T : GuiMonsterDefinition
        {
            entity.SetField("<MonsterDefinition>k__BackingField", value);
            return entity;
        }
    }
}
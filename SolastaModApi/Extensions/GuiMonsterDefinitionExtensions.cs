using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiMonsterDefinition))]
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
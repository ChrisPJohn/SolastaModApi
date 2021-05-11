using SolastaModApi.Infrastructure;
using System.Text;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiQuest))]
    public static class GuiQuestExtensions
    {
        public static T SetGameQuest<T>(this T entity, GameQuest value)
            where T : GuiQuest
        {
            entity.SetField("gameQuest", value);
            return entity;
        }

        public static T SetStringBuilder<T>(this T entity, StringBuilder value)
            where T : GuiQuest
        {
            entity.SetField("stringBuilder", value);
            return entity;
        }
    }
}
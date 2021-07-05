using SolastaModApi.Infrastructure;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(SummonForm))]
    public static partial class SummonFormExtensions
    {
        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : SummonForm
        {
            entity.SetField("conditionDefinition", value);
            return entity;
        }

        public static T SetDecisionPackage<T>(this T entity, DecisionPackageDefinition value)
            where T : SummonForm
        {
            entity.SetField("decisionPackage", value);
            return entity;
        }

        public static T SetEffectProxyDefinitionName<T>(this T entity, string value)
            where T : SummonForm
        {
            entity.SetField("effectProxyDefinitionName", value);
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : SummonForm
        {
            entity.SetField("itemDefinition", value);
            return entity;
        }

        public static T SetMonsterDefinitionName<T>(this T entity, string value)
            where T : SummonForm
        {
            entity.SetField("monsterDefinitionName", value);
            return entity;
        }

        public static T SetNumber<T>(this T entity, int value)
            where T : SummonForm
        {
            entity.SetField("number", value);
            return entity;
        }

        public static T SetPersistOnConcentrationLoss<T>(this T entity, bool value)
            where T : SummonForm
        {
            entity.SetField("persistOnConcentrationLoss", value);
            return entity;
        }

        public static T SetSummonType<T>(this T entity, SummonForm.Type value)
            where T : SummonForm
        {
            entity.SetField("summonType", value);
            return entity;
        }
    }
}
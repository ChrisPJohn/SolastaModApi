using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static RuleDefinitions;
using static MorphotypeElementDefinition;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MorphotypeElementDefinition))]
    public static partial class MorphotypeElementDefinitionExtensions
    {
        public static T SetBodyDecorationBlendFactor<T>(this T entity, float value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("bodyDecorationBlendFactor", value);
            return entity;
        }

        public static T SetBodyDecorationType<T>(this T entity, GraphicsDefinitions.BodyDecorationType value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("bodyDecorationType", value);
            return entity;
        }

        public static T SetCategory<T>(this T entity, ElementCategory value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("category", value);
            return entity;
        }

        public static T SetMainColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("mainColor", value);
            return entity;
        }

        public static T SetMinMaxValue<T>(this T entity, RangedFloat value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("minMaxValue", value);
            return entity;
        }

        public static T SetOriginAllowed<T>(this T entity, string[] value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("originAllowed", value);
            return entity;
        }

        public static T SetPlayerSelectable<T>(this T entity, bool value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("playerSelectable", value);
            return entity;
        }

        public static T SetReplaceEyeColorMask<T>(this T entity, bool value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("replaceEyeColorMask", value);
            return entity;
        }

        public static T SetSecondColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("secondColor", value);
            return entity;
        }

        public static T SetSubClassFilterMask<T>(this T entity, GraphicsDefinitions.MorphotypeSubclassFilterTag value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("subClassFilterMask", value);
            return entity;
        }

        public static T SetThirdColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("thirdColor", value);
            return entity;
        }
    }
}
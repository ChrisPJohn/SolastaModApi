using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GadgetParameterDescription))]
    public static class GadgetParameterDescriptionExtensions
    {
        public static T SetBoolDefaultValue<T>(this T entity, bool value)
            where T : GadgetParameterDescription
        {
            entity.SetField("boolDefaultValue", value);
            return entity;
        }

        public static T SetConditionalDisplay<T>(this T entity, bool value)
            where T : GadgetParameterDescription
        {
            entity.SetField("conditionalDisplay", value);
            return entity;
        }

        public static T SetConditionalMatch<T>(this T entity, bool value)
            where T : GadgetParameterDescription
        {
            entity.SetField("conditionalMatch", value);
            return entity;
        }

        public static T SetConditionalParameter<T>(this T entity, string value)
            where T : GadgetParameterDescription
        {
            entity.SetField("conditionalParameter", value);
            return entity;
        }

        public static T SetIntDefaultValue<T>(this T entity, int value)
            where T : GadgetParameterDescription
        {
            entity.SetField("intDefaultValue", value);
            return entity;
        }

        public static T SetIntMaxValue<T>(this T entity, int value)
            where T : GadgetParameterDescription
        {
            entity.SetField("intMaxValue", value);
            return entity;
        }

        public static T SetIntMinValue<T>(this T entity, int value)
            where T : GadgetParameterDescription
        {
            entity.SetField("intMinValue", value);
            return entity;
        }

        public static T SetName<T>(this T entity, string value)
            where T : GadgetParameterDescription
        {
            entity.SetField("name", value);
            return entity;
        }

        public static T SetRequiresNonEmpty<T>(this T entity, bool value)
            where T : GadgetParameterDescription
        {
            entity.SetField("requiresNonEmpty", value);
            return entity;
        }

        public static T SetType<T>(this T entity, GadgetBlueprintDefinitions.Type value)
            where T : GadgetParameterDescription
        {
            entity.SetField("type", value);
            return entity;
        }
    }
}
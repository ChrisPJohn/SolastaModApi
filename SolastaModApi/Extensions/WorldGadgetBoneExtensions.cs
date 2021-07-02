using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WorldGadgetBone))]
    public static partial class WorldGadgetBoneExtensions
    {
        public static T SetBoneType<T>(this T entity, GadgetDefinitions.BoneType value)
            where T : WorldGadgetBone
        {
            entity.SetField("boneType", value);
            return entity;
        }
    }
}
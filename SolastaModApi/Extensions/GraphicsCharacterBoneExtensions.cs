using SolastaModApi.Infrastructure;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GraphicsCharacterBone))]
    public static partial class GraphicsCharacterBoneExtensions
    {
        public static T SetBoneType<T>(this T entity, BoneType value)
            where T : GraphicsCharacterBone
        {
            entity.BoneType = value;
            return entity;
        }
    }
}
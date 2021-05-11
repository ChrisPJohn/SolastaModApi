using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class WorldGadgetBoneExtensions
    {
        public static T SetBoneType<T>(this T entity, GadgetDefinitions.BoneType value)
            where T : WorldGadgetBone
        {
            entity.SetField("boneType", value);
            return entity;
        }
    }
}
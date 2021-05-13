using System;

namespace SolastaModApi
{
    [Obsolete("Use CharacterSubclassDefinitionBuilder")]
    public class SubClassBuilder : CharacterSubclassDefinitionBuilder
    {
        public SubClassBuilder(string name, string guid) : base(name, guid)
        {
        }
    }
}

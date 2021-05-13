using System;

namespace SolastaModApi
{
    [Obsolete("Use CharacterClassDefinitionBuilder")]
    public class ClassBuilder : CharacterClassDefinitionBuilder
    {
        // The only change is that the ctor requires name and guid
        public ClassBuilder(string name, string guid) : base(name, guid)
        {
        }
    }
}

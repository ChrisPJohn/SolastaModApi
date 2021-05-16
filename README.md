# Solasta Mod Api

A mod to consolidate helpers, builders, etc

# Guidelines for use

## Extension classes
Mod Api now comes with many (>200) extension classes to help eliminate a lot of manual work in setting private fields.
For example given this extension class:

```
public static class ArmorDescriptionExtensions
{
    public static T SetArmorClassValue<T>(this T entity, int value)
        where T : ArmorDescription
    {
        entity.SetField("armorClassValue", value);
        return entity;
    }

    public static T SetArmorType<T>(this T entity, string value)
        where T : ArmorDescription
    {
        entity.SetField("armorType", value);
        return entity;
    }	
	...
```

You can write code like this:

```
var description = new ArmorDescription()
    .SetArmorClassValue(5)
    .SetArmorType("heavy");
```

Note: Here we created `ArmorDescription` with `new` since it's a simple type. It's recommended to create objects derived from `UnityEngine.ScriptableObject` with `ScriptableObject.CreateInstance<T>()`.

### Helpers
There are other helpers.  Most notably `object.SetField(field-name, value)` extension method implements and replaces `Traverse.Create(object).Field(field-name).SetValue(value)`. Unfortunately`Traverse.Create(object).Field(field-name).SetValue(value)` always 'succeeds' even if 'field-name' doesn't exist.
`SetField` will detect this and throw an error.

You are therefore recommended to: 
1) use an available extension class if one is available 
2) use `SetField` otherwise.

## BaseDefinition types
Types derived from `BaseDefinition` need more careful handling since they need:
1) A unique name
2) A unique guid
3) Adding to the correct 'database'.

For this reason it is recommended to create BaseDefinition types using a Builder class derived from `BaseDefinitionBuilder<T>`.

e.g.

```
public class CharacterSubclassDefinitionBuilder : BaseDefinitionBuilder<CharacterSubclassDefinition>
{
  // create using name and a guid as a string
  public CharacterSubclassDefinitionBuilder(string name, string guid) : base(name, guid){}
  
  // create using name and a Guid.  The base class will derive the guid string.
  public CharacterSubclassDefinitionBuilder(string name, Guid guidNamespace) : base(name, guidNamespace){}
  
  public CharacterSubclassDefinitionBuilder SetGuiPresentation(GuiPresentation gui)
  {
    Definition.SetGuiPresentation(gui);
    return this;
  }

  public CharacterSubclassDefinitionBuilder AddPersonality(PersonalityFlagDefinition personalityType, int weight)
  {
    var personalityFlag = new PersonalityFlagOccurence()
    	.SetWeight(weight)
    	.SetPersonalityFlag(personalityType.Name);

    Definition.PersonalityFlagOccurences.Add(flag);
    return this;
  }

  public CharacterSubclassDefinitionBuilder AddFeatureAtLevel(FeatureDefinition feature, int level)
  {
    Definition.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
    return this;
  }
}
```

An example of usage from SolastaSampleMod

```
var definition = 
    new CharacterSubclassDefinitionBuilder("MasterManipulator", ModGuidNamespace)
        .SetGuiPresentation(controlPresentation)
        .AddFeatureAtLevel(arcaneControlAffinity, 2)
        .AddFeatureAtLevel(arcaneForceAffinity, 6)
        // BaseDefinitionBuilder<T> implements AddToDB which puts your Definition 
        // in the correct database (or databases) and then returns the CharacterSubclassDefinition
        .AddToDB();
```
Note that if you called AddToDB() above a second time an exception would be thrown.

# How to Compile

1. Install Visual Studio 2019
2. Ensure the SolastaInstallDir environment variable is configured to point to your Solasta_COTM install directory.
3. Use "InstallDebug" to have it installed directly to your Mods folder

# How to Install

1. Download and install [Unity Mod Manager](https://www.nexusmods.com/site/mods/21)
2. Execute Unity Mod Manager, Select Solasta, and Install
3. Select Mods tab, drag and drop from releases

# How to Debug

1. Open Solasta game folder
	* Rename Solasta.exe to Solasta.exe.original
	* Rename UnityPlayer.dll to UnityPlayer.dll.original
	* Add below entries to *Solasta_Data\boot.config*:
```
wait-for-managed-debugger=1
player-connection-debug=1
```
2. Download and install [7zip](https://www.7-zip.org/a/7z1900-x64.exe)
3. Download [Unity Editor 2019.4.19](https://download.unity3d.com/download_unity/ca5b14067cec/Windows64EditorInstaller/UnitySetup64-2019.4.19f1.exe)
4. Open Downloads folder
	* Right-click UnitySetup64-2019.4.1f1.exe, 7Zip -> Extract Here
	* Navigate to Editor\Data\PlaybackEngines\windowsstandalonesupport\Variations\win64_development_mono
		* Copy *UnityPlayer.dll* and *WinPixEventRuntime.dll* to Solasta game folder
	* Navigate to Solasta game folder
		* Rename *UnityPlayer.dll* to *UnityPlayer.dll.original*
		* Paste *UnityPlayer.dll* and *WinPixEventRuntime.dll* from previous step

You can now attach the Unity Debugger from Visual Studio 2019, Debug -> Attach Unity Debug

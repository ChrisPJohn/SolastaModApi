# Solasta Mod Api

A mod to consolidate helpers, builders, etc

# How to Compile

1. Install Visual Studio 2019
2. Ensure the SolastaInstallDir environment variable is configured to point to your Solasta_COTM install directory.
3. Use "InstallDebug" to have it installed directly to your Mods folder

# How to Install

1. Download and instal [Unity Mod Manager](https://www.nexusmods.com/site/mods/21)
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

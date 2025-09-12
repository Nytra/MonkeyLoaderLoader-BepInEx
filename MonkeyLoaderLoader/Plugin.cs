using BepInEx;
using BepInEx.Logging;
using BepInEx.NET.Common;
using BepInExResoniteShim;

namespace MonkeyLoaderLoader.BepInEx;

[ResonitePlugin(PluginMetadata.GUID, PluginMetadata.NAME, PluginMetadata.VERSION, PluginMetadata.AUTHORS, PluginMetadata.REPOSITORY_URL)]
[BepInDependency(BepInExResoniteShim.PluginMetadata.GUID, BepInDependency.DependencyFlags.HardDependency)]
public class Plugin : BasePlugin
{
	internal static new ManualLogSource? Log;

	public override void Load()
	{
		Log = base.Log;
		Log.LogInfo($"Loading MonkeyLoader!");
		MonkeyLoaderLoader.Load(HarmonyInstance);
	}
}
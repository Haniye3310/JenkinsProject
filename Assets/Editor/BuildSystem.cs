using UnityEditor;
using System.Linq;

public static class BuildSystem 
{
    public static void BuildWindows()
    {
        var scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        BuildPipeline.BuildPlayer(
            scenes,
            "Builds/Windows/MyGame.exe",       // output path
            BuildTarget.StandaloneWindows64,   // target
            BuildOptions.None                  // no extra options
        );
    }
}

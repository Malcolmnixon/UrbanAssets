using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public class Builder
{
    [MenuItem("Build/UrbanDemo/Build All")]
    public static void BuildAll() {
        BuildWin64();
        BuildLin64();
        BuildAndroid();
    }

	[MenuItem("Build/UrbanDemo/Build Windows 64-bit")]
    public static void BuildWin64()
    {
		PrintReport(BuildPipeline.BuildPlayer(
            new[] {
				"Assets/Scenes/Urban/UrbanDemo.unity"
            },
            "Build/Win64/UrbanDemo.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None));
    }

	[MenuItem("Build/UrbanDemo/Build Linux 64-bit")]
    public static void BuildLin64()
    {
		PrintReport(BuildPipeline.BuildPlayer(
            new[] {
				"Assets/Scenes/Urban/UrbanDemo.unity"
            },
			"Build/Linux/UrbanDemo.x86_64",
            BuildTarget.StandaloneLinux64,
            BuildOptions.None));
    }

	[MenuItem("Build/UrbanDemo/Build Android")]
    public static void BuildAndroid()
    {
		PrintReport(BuildPipeline.BuildPlayer(
            new[] {
				"Assets/Scenes/Urban/UrbanDemo.unity"
            },
			"Build/Android/UrbanDemo.apk",
            BuildTarget.Android,
            BuildOptions.None));
    }


	private static void PrintReport(BuildReport report) {
		var summary = report.summary;
		if (summary.result == BuildResult.Succeeded) {
			Debug.Log($"Build Succeeded {summary.totalSize} bytes");
		} else {
			Debug.Log("Build Failed");
		}
	}
}

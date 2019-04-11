using UnityEngine;
using UnityEditor;

// MIT License
// (c) 2019 gatosyocora

namespace Gatosyocora
{

    public class UploadPlatformChecker : Editor
    {

        private static GUIStyle labelStyle;
        private static Rect windowSize = new Rect(8, 24, 150, 40);
        private static bool enabled = false;
        private static bool canUseAndroidPlatform = true;
        private static string selectedPlatformName = "PC";

        [InitializeOnLoadMethod]
        static void UploadPlatformCheck()
        {
            SceneView.onSceneGUIDelegate += OnSceneGUI;
        }

        static void OnSceneGUI(SceneView sceneView)
        {

            GUI.WindowFunction func = id =>
            {
                labelStyle = new GUIStyle(EditorStyles.label);
                labelStyle.normal.textColor = Color.white;
                labelStyle.wordWrap = true;

                using (new EditorGUILayout.HorizontalScope())
                {
                    GUILayout.FlexibleSpace();

                    if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android)
                        selectedPlatformName = "Android";
                    else if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
                        selectedPlatformName = "PC";
                    else
                        selectedPlatformName = "Other";

                    EditorGUILayout.LabelField(selectedPlatformName, labelStyle);

                    GUILayout.FlexibleSpace();
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("PC", GUILayout.Width(70)))
                    {
                        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64);
                    }
                    if (GUILayout.Button("Android", GUILayout.Width(70)))
                    {
                        canUseAndroidPlatform = EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
                    }
                }


                if (!canUseAndroidPlatform)
                {
                    EditorGUILayout.HelpBox("Need to install Unity's Android SDK", MessageType.Error);
                    if (GUILayout.Button("Open Build Settings"))
                    {
                        EditorUserBuildSettings.selectedBuildTargetGroup = BuildTargetGroup.Android;
                        EditorApplication.ExecuteMenuItem("File/Build Settings...");
                    }
                }
            };

            GUILayout.Window(1, windowSize, func, "Selected Platform");
        }
    }

}

// ============================================================================
// File:        HelloSceneBuilder.cs  (EDITOR ONLY - never ships in a build)
// Author:      Prince John
// Project:     Hello Unity - GPE104 Project 1, Milestone 1
// Description: Builds the milestone scene from code: one sphere game
//              object with the HelloWorld component attached. In Unity:
//              Hello Unity > Build Scene, then press Play and watch the
//              Console print "Hello World".
// ============================================================================
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class HelloSceneBuilder
{
    private const string ScenePath = "Assets/Scenes/HelloUnity.unity";

    [MenuItem("Hello Unity/Build Scene")]
    public static void BuildScene()
    {
        var scene = EditorSceneManager.NewScene(
            NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // One simple shape in the game world: a sphere.
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = "HelloSphere";
        sphere.transform.position = Vector3.zero;

        // Attach the custom component that prints "Hello World".
        sphere.AddComponent<HelloWorld>();

        EditorSceneManager.SaveScene(scene, ScenePath);
        EditorBuildSettings.scenes = new[]
        {
            new EditorBuildSettingsScene(ScenePath, true)
        };
        AssetDatabase.SaveAssets();
        Debug.Log("Hello Unity scene built and saved to " + ScenePath);
    }
}

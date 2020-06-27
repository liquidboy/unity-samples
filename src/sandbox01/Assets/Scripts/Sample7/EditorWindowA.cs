using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EditorWindowA : EditorWindow
{
    [MenuItem("Window/My Window")]
    public static void ShowWindow()
    {
        EditorWindow w = EditorWindow.GetWindow(typeof(EditorWindowA));

        VisualTreeAsset uiAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Scripts/Sample7/EditorWindowA.uxml");
        VisualElement ui = uiAsset.CloneTree(string.Empty);

        w.rootVisualElement.Add(ui);
    }

    void OnGUI()
    {
        // Nothing to do here, unless you need to also handle IMGUI stuff.
    }
}

using UnityEditor;

namespace io.github.ykysnk.ModularAvatarExtensions.Editor;

[CustomEditor(typeof(D4RkAvatarOptimizerExclude))]
public class D4RkAvatarOptimizerExcludeEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUI.BeginChangeCheck();

        EditorGUILayout.HelpBox("This object will be exclude in d4rk Avatar Optimizer", MessageType.Info, true);

        if (EditorGUI.EndChangeCheck())
            serializedObject.ApplyModifiedProperties();
    }
}
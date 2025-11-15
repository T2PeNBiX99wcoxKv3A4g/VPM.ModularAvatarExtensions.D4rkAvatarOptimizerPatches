using UnityEditor;

namespace io.github.ykysnk.ModularAvatarExtensions.Editor;

[CustomEditor(typeof(D4RkAvatarOptimizerExclude))]
[CanEditMultipleObjects]
public class D4RkAvatarOptimizerExcludeEditor : MaexEditor
{
    protected override void OnInspectorGUIDraw()
    {
        EditorGUILayout.HelpBox("This object will be exclude in d4rk Avatar Optimizer", MessageType.Info, true);
    }
}
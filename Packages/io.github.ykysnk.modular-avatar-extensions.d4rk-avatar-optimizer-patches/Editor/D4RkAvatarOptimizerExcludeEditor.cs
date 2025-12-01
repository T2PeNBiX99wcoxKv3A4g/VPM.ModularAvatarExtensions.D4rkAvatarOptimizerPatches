using io.github.ykysnk.Localization.Editor;
using UnityEditor;

namespace io.github.ykysnk.ModularAvatarExtensions.Editor;

[CustomEditor(typeof(ModularAvatarExtensionsD4RkAvatarOptimizerExclude))]
[CanEditMultipleObjects]
public class D4RkAvatarOptimizerExcludeEditor : MaexEditor
{
    private const string LocalizationID = "io.github.ykysnk.modular-avatar-extensions";

    protected override void OnMaexInspectorGUI()
    {
        EditorGUILayout.HelpBox("label.d4rk_avatar_optimizer_exclude.info".L(LocalizationID), MessageType.Info, true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerController))]
public class JugadorEditor : Editor
{

    public override void OnInspectorGUI() 
    {
        base.OnInspectorGUI();

        PlayerController playerController = (PlayerController) target;
        playerController.inputProvider = EditorGUILayout.ObjectField ("inputProvider", playerController.inputProvider, typeof (AInputProvider), true);
    //   DrawDefaultInspector ();
    }
}

using UnityEngine;
using UnityEditor;
using System.Collections;

public class MyTool : EditorWindow
{
    private GameObject prefab;
    private GameObject prefab2;
    private GameObject prefab3;
    private GameObject prefab4;

    [MenuItem("Tools/My Tool")]
    public static void ShowWindow()
    {
        GetWindow<MyTool>("My Tool");
    }
    private void OnGUI() //Cuando se dibujan cosas en la interfaz de Unity
    {
        GUILayout.Space(30);
        GUILayout.Label("Mis herramientas", EditorStyles.boldLabel);
        GUILayout.Space(30);
        EditorGUILayout.HelpBox("Esta herramienta sirve para creear mapas random", MessageType.Info);
        GUILayout.Space(30);
        prefab = EditorGUILayout.ObjectField("Prefab", prefab, typeof(GameObject), false) as GameObject;
        GUILayout.Space(30);

        prefab = EditorGUILayout.ObjectField("Prefab2", prefab2, typeof(GameObject), false) as GameObject;
        GUILayout.Space(30);
     

        prefab = EditorGUILayout.ObjectField("Prefab3", prefab3, typeof(GameObject), false) as GameObject;
        GUILayout.Space(30);


        prefab = EditorGUILayout.ObjectField("Prefab4", prefab4, typeof(GameObject), false) as GameObject;
        GUILayout.Space(30);

        if (GUILayout.Button("Crear barrio2"))
        {
            CreateCube();
        }
    }
    private void CreateCube()
    {
        Debug.Log("Creo un cubo");
        GameObject clone = (GameObject) PrefabUtility.InstantiatePrefab(prefab);

        Undo.RegisterCreatedObjectUndo(clone, "Crear cubo");
        int UndoID = Undo.GetCurrentGroup();
        Undo.RegisterCreatedObjectUndo(clone, "Crear cubo");
        Undo.CollapseUndoOperations(UndoID);
    }
}

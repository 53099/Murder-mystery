using UnityEditor;
using UnityEngine;

public class BehaviourEditor : EditorWindow
{
    public BehaviourContainer container;
    [MenuItem("Behaviour Editor/Editor")]
    static void ShowEditor()
    {
        EditorWindow window = EditorWindow.GetWindow(typeof(BehaviourEditor));
        window.minSize = new Vector2(800, 600);
    }

    private void OnGUI()
    {
        container = (BehaviourContainer)EditorGUILayout.ObjectField(container, typeof(BehaviourContainer), false);

        BeginWindows();

        if (container != null)
        {
            for (int i = 0; i < container.nodes.Count; i++)
            {
                container.nodes[i].nodeRect = GUI.Window(i, container.nodes[i].nodeRect, DrawNode, container.nodes[i].title);
            }
        }

        EndWindows();
    }
    
    void DrawNode(int id)
    {
        container.nodes[id].DrawNode();
        GUI.DragWindow();
    }
}

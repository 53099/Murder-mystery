using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviour Editor/Draw/Text Node")]
public class TextNode : DrawNode
{
    public override void DrawWindow(DialogueNode b)
    {
        b.nodeRect.height = 80;
        b.nodeRect.width = 200;
        b.character = (Character)EditorGUILayout.ObjectField(b.character, typeof(Character), false);
        b.cameraEffect = (CameraEffect)EditorGUILayout.ObjectField(b.cameraEffect, typeof(CameraEffect), false);
        if(b.textLines == null) { return; }

        for (int i = 0; i < b.textLines.Count; i++)
        {
            EditorGUILayout.Separator();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Line #" + i.ToString());
            if(GUILayout.Button("X", GUILayout.Width(20)))
            {
                b.textLines.RemoveAt(i);
                continue;
            }
            GUILayout.EndHorizontal();
            b.textLines[i].text = GUILayout.TextField(b.textLines[i].text);
            b.textLines[i].textEffect = (TextEffect)EditorGUILayout.ObjectField(b.textLines[i].textEffect, typeof(TextEffect), false);
            b.nodeRect.height += 64;
        }
    }
}

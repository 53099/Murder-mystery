using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TextLine
{
    public string text;
    public TextEffect textEffect;
}

[System.Serializable]
public class DialogueNode 
{
    public Rect nodeRect;
    public string title;

    public DrawNode drawNode;



    public string text;

    public Character character;
    public CameraEffect cameraEffect;

    public List<TextLine> textLines;

    public DialogueNode(DrawNode _drawNode)
    {
        drawNode = _drawNode;
    }

    public void DrawNode()
    {
        if (drawNode != null)
        {
            drawNode.DrawWindow(this);
        }
    }
}

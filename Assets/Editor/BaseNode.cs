using UnityEngine;

[System.Serializable]
public class BaseNode
{
    public Rect nodeRect;
    public string title;

    public DrawNode drawNode;

    public void DrawNode()
    {
        if (drawNode != null)
        {
            drawNode.DrawWindow(this);
        }
    }
}

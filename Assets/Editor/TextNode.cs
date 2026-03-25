using UnityEngine;

[CreateAssetMenu(menuName = "BehaviourEditor/Draw/Text Node")]
public class TextNode : DrawNode
{
    public override void DrawWindow(BaseNode b)
    {
        b.nodeRect.height = 140;
        b.nodeRect.width = 200;
    }
}

using NUnit.Framework;
using UnityEngine;


[CreateAssetMenu(menuName = "Behaviour Editor/ Container")]
public class BehaviourContainer : ScriptableObject
{
    public List<BaseNode> nodes;
}

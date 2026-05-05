using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Stage")]
public class Stage : ScriptableObject
{
    public List<DialogueNode> dialogueNodes;
}

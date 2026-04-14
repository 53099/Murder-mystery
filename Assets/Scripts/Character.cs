using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public enum Characterstate
{
    Idle = 0,
    Surpised = 1,
    Angry = 2,
}

[CreateAssetMenu(menuName ="Data/Character")]
public class Character : ScriptableObject
{
    public string Name;
    public List<Texture> sprites;
}

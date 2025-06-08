using UnityEngine;

public interface IBrickSettings
{
    float Width { get; }
    float Height { get; }
    Sprite[] Sprites { get; }
}
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TileSprites", menuName = "Tiles/Sprite Collection")]
public class SpriteCollectionSO : ScriptableObject
{
    public List<Sprite> Sprites = new List<Sprite>();
}
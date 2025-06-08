using UnityEngine;

[CreateAssetMenu(fileName = "BrickSettings", menuName = "Game/BrickSettings")]
public class BrickSettingsSO : ScriptableObject, IBrickSettings
{
    public float Width => _width;
    public float Height => _height;
    public Sprite[] Sprites => _sprites;

    [SerializeField] private float _width = 1.5f;
    [SerializeField] private float _height = 2f;
    [SerializeField] private Sprite[] _sprites;

}
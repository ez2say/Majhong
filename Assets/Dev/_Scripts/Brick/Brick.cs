using UnityEngine;

public class Brick : MonoBehaviour, IBrick
{
    private SpriteRenderer _spriteRenderer;

    public void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetSprite(Sprite sprite)
    {
        _spriteRenderer.sprite = sprite;
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
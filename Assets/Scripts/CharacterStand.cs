using UnityEngine;

public class CharacterStand : MonoBehaviour
{

    public Character character;
    public CharacterState state;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer.transform.localScale = character.scale;
        SetSprite();
    }

    private void Update()
    {
        SetSprite();
    }

    public void SetSprite()
    {
        spriteRenderer.sprite = character.sprites[(int)state];

    }

}

using UnityEngine;

public class CardView : MonoBehaviour
{
    Card _card = new Card();
    [SerializeField] SpriteSwapper _valueSprite;
    [SerializeField] SpriteSwapper _suitSprite;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        UpdateSprites();
    }

    public void SetCard(Card card)
    {
        _card = card;
        UpdateSprites();
    }

    public void UpdateSprites()
    {
            _valueSprite.SetValue(_card);
            _suitSprite.SetSuit(_card);
    }

    public void Flip()
    {
        _animator.SetTrigger("flip");
    }
}

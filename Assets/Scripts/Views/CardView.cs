using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardView : MonoBehaviour
{
    [SerializeField] Card _card;
    [SerializeField] SpriteSwapper _valueSprite;
    [SerializeField] SpriteSwapper _suitSprite;

    bool _faceUp = false;
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
        _faceUp = !_faceUp;
        _animator.SetBool("face_up", _faceUp);
        _animator.SetTrigger("flip");
    }
}

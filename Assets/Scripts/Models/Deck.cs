using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Deck
{
    [SerializeField]
    protected List<Card> _cards = new List<Card>();
    public int Count => _cards.Count;
    public Deck() { }
    public void Add(Card card) { _cards.Add(card); }
    public bool Remove(Card card) { return _cards.Remove(card);}

    public void BuildBasicDeck(bool withJokers = false)
    {
        _cards = new List<Card>();

        for (int suitInt = 0; suitInt <= 3; suitInt++) 
        { 
            for(int valueInt = (int)Value.ACE; valueInt <= (int) Value.KING; valueInt++)
            {
                Add(new Card(valueInt, suitInt));
            }
        }

        if(withJokers)
        {
            Add(new Card(Value.JOKER, Suit.SPADE));
            Add(new Card(Value.JOKER, Suit.HEART));
        }
    }

    public void Shuffle()
    {
        int n = _cards.Count;
        while(n > 1)
        {
            n--;
            int r = UnityEngine.Random.Range(0, n + 1);
            Card tempCard = _cards[r];
            _cards[r] = _cards[n];
            _cards[n] = tempCard;

        }
    }

    public Card DrawTop()
    {
        if (_cards.Count == 0)
            return new Card(Value.EMPTYDECK, Suit.ERROR);

        Card c = _cards[_cards.Count - 1];
        Remove(c);
        return c;
    }

    
}

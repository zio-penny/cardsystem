using System;
using UnityEngine;

[Serializable]
public struct Card
{
    [SerializeField]
    private Value _value;
    [SerializeField]
    private Suit _suit;

    public Value Value => _value;
    public Suit Suit => _suit;

    public void SetCard(Value value, Suit suit)
    {
        _value = value;
        _suit = suit;
    }
}

public enum Suit
{
    BLACK, SPADE, CLUB, RED, HEART, DIAMOND, 
}

public enum Value
{
    JOKER, ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING,
}

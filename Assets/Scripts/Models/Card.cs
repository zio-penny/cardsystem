using System;
using UnityEngine;

[Serializable]
public struct Card
{
    [SerializeField]
    public Value Value;
    [SerializeField]
    public Suit Suit;
    public Card (Value value = Value.NULL, Suit suit = Suit.NULL)
    {
        Value = value;
        Suit = suit;
    }

    public Card(int valueInt = (int)Value.NULL, int suitInt = (int)Suit.NULL)
    {
        Value = (Value)valueInt;
        Suit = (Suit)suitInt;
    }
}

public enum Suit
{ 
    SPADE, CLUB, HEART, DIAMOND, NULL, ERROR
}

public enum Value
{
    NULL, ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, JOKER, EMPTYDECK
}

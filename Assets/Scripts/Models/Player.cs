using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Deck
{
    int _wallet = 0;
    int _currentWager = 0;
    public int HandCount => _cards.Count;
    public Player() 
    {
        
    }

    public void RecieveTokens(int numTokens)
    {
        _wallet += numTokens;
    }
}

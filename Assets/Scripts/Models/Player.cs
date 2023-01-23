using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Deck
{
    int wallet = 0;
    int wager = 0;
    public int HandCount => _cards.Count;
    public Player() 
    {
        
    }
}

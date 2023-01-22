using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "deck", menuName = "NinjaEggAssets/Deck Build")]
public class SODeckBuild : ScriptableObject
{
    public string DeckName = "newDeck";
    public List<Card> cards;

}

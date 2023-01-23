
using System;
using System.Collections.Generic;
using UnityEngine;

public delegate void SetDealerEvent(int playerInt);
public delegate void DealPlayersEvent();
public delegate void ErrorEvent();

[Serializable]
public class HoldemGame
{
    [SerializeField]
    Deck _mainDeck;
    int _numberOfPlayers;
    [SerializeField]
    Player[] _players;
    int currentPlayer = 0;
    int _dealer = 0;

    public static event SetDealerEvent OnSetDealer;
    public static event DealPlayersEvent OnSetDealPlayers;
    public static event ErrorEvent OnError;

    public HoldemGame(int numberOfPlayers = 2)
    {
        _mainDeck = new Deck();
        _numberOfPlayers = numberOfPlayers;
        _players = new Player[_numberOfPlayers];
        for(int i = 0; i < _numberOfPlayers; i++)
        {
            _players[i] = new Player();
        }

        SetDealer(UnityEngine.Random.Range(0, _numberOfPlayers));
    }

    public void StartGame()
    {
        _mainDeck.BuildBasicDeck();
        _mainDeck.Shuffle();
        DealPlayers();
    }

    public void SetDealer(int dealer)
    {
        _dealer = dealer;
        OnSetDealer.Invoke(dealer);
    }

    private void DealPlayers()
    {
        currentPlayer = (_dealer + 1) % _numberOfPlayers; // start with person following dealer

        // deal 2 cards to all players, round robin style
        while (_players[currentPlayer].HandCount < 2)
        {
            Card drawnCard = _mainDeck.DrawTop();
            if(drawnCard.Suit == Suit.ERROR)
            {
                OnError.Invoke();
                return;
            }

            _players[currentPlayer].Add(drawnCard);

            currentPlayer++;
            currentPlayer %= _numberOfPlayers;
        }

        OnSetDealPlayers.Invoke();
    }
}

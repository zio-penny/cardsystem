using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    [SerializeField] Color _black = new Color(34.0f/255.0f, 17.0f/255.0f,34.0f/255.0f);
    [SerializeField] Color _red = new Color(94/255.0f, 17/255.0f, 23/255.0f);

    MeshRenderer _meshRenderer;
    Material _material;

    const int SPRITESHEET_WIDTH_IN_CELLS = 4;

    private void Awake()
    {
        _meshRenderer= GetComponentInChildren<MeshRenderer>();
        _material = _meshRenderer.material;
    }

    public void SetValue(Card card) 
    {
        int iconIndex = (int)card.Value - 1;
        int offsetx = iconIndex % SPRITESHEET_WIDTH_IN_CELLS;
        int offsety = iconIndex / SPRITESHEET_WIDTH_IN_CELLS;
        _material.SetVector("_cellOffset", (Vector4)new Vector2(offsetx, offsety));
        SetColor(card.Suit);
    }

    public void SetSuit(Card card)
    {
        int offsetx = (int)card.Suit;
        _material.SetVector("_cellOffset", (Vector4)new Vector2(offsetx, 4));
        SetColor(card.Suit);
    }

    private void SetColor(Suit suit)
    {
        Color color = (int)suit < 2 ? _black : _red;
        _material.SetColor("_mainColor", color);
    }

    public void ClearIcons()
    {
        _material.SetVector("_cellOffset", (Vector4)new Vector2(1, 3));
    }
}
/********************************************
// 0 : Queen
// 1-3 : Empty
// 5-8: heart, diamond, club, spade
// 9-12: 9-k
// 13-16: 5-8
// 17-20: a-4
**********************************************/
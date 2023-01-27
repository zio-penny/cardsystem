using UnityEngine;
using UnityEngine.InputSystem;

public class HoldemGameManager : MonoBehaviour
{
    [SerializeField] Card _card;
    [SerializeField] CardView _testCardView;

    private void Start()
    {
        _testCardView.SetCard(_card);
    }

    private void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _testCardView.SetCard(_card);
            _testCardView.Flip();
        }

        if(Keyboard.current.zKey.wasPressedThisFrame)
        {
            _testCardView.SetCard(_card);
        }
    }
}

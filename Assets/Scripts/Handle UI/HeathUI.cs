using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathUI : MonoBehaviour
{
    [SerializeField] PlayerHeathSystem _playerHeathSystem;
    [SerializeField] Slider _playerHeathBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPlayerHeath();
    }

    void DisplayPlayerHeath()
    {
        float playerHeath = _playerHeathSystem.PlayerHeath;
        _playerHeathBarSlider.value = playerHeath;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerHeathSystem _playerHeathSystem;
    [SerializeField] TextMeshProUGUI _playerHeathText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerHeath();
    }

    void UpdatePlayerHeath()
    {
        float playerHeath = _playerHeathSystem.PlayerHeath;
        _playerHeathText.SetText("Heath: " + playerHeath);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Top : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI jewelText;

    void Start()
    {
        
    }

    void Update()
    {
    }

    public void UpdateCurrency()
    {
        goldText.text = OutGameManager.instance.Coin.ToString();
        jewelText.text = OutGameManager.instance.Jewel.ToString();
    }
}

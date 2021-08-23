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
        goldText.text = "";
        jewelText.text = "";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Health health;
    public CoinsCounter coin;
    public TextMeshProUGUI coinsText;
    public Slider healthSlider;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;
        
        coinsText.text = coin.coin.ToString();
    }
}

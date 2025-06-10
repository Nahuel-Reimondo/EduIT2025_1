using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManagerEvents : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    
    private int currentKills = 0;
    
    public void UpdateKills()
    {
        currentKills++;
        text.text = "Kills: " + currentKills.ToString() +".";
    }
}

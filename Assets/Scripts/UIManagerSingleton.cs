using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManagerSingleton : MonoBehaviour
{
    public static UIManagerSingleton instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private int currentKills = 0;
    private int currentScore = 0;
    
    
    public void UpdateKills()
    {
        currentKills++;
        text.text = "Kills: " + currentKills.ToString() +".";
    }
    
    public void UpdateScore(int addScore)
    {
        currentScore += addScore;
        text.text = "Score: " + currentScore;
    }
}

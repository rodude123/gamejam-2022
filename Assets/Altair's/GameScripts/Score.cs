using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    private int totalScore;
    private int highScore;
    private int totalEnemiesKilled;
    private int highTotalEnemiesKilled;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndGame()
    {
        if (totalScore > highScore)
        {
            highScore = totalScore;
        }
    }

    // iscore?
    public void Tier1Enemy()
    {
        totalScore += 1;
    }
    
    public void Tier2Enemy()
    {
        totalScore += 5;
    }
    
    public void Tier3Enemy()
    {
        totalScore += 10;
    }
    
    public void Tier4Enemy()
    {
        totalScore += 20;
    }
    
    public void Tier5Enemy()
    {
        totalScore += 50;
    }
}

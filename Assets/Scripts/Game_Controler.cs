using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controler : MonoBehaviour
{
    public Text HighScoreText ;
    public Text scoreText;
    public int Score;
    public int highScore;
    public score_Manager score_manager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        Score = score_manager.Score;

        HighScoreText.text =highScore.ToString();
        scoreText.text=Score.ToString(); 
    }
}

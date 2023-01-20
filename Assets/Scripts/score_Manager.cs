using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_Manager : MonoBehaviour
{
    public int Score = 0;
    public int highScore;
    public static int lastscore=0;

    public Text scoreText;
    public Text HighScoreText;
    public Text lastScoreText;

    void Start()
    {
        StartCoroutine(score());
        
        highScore = PlayerPrefs.GetInt("high_score" ,0);
        HighScoreText.text ="High Score:" + highScore.ToString();
        lastScoreText.text ="Last Score:" + lastscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      scoreText.text= Score.ToString();
      if (Score > highScore){
        highScore = Score ;
        PlayerPrefs.SetInt("high_Score",highScore);
      }
    }

    IEnumerator score(){
        while(true){
            yield return new WaitForSeconds(2);
        Score = Score + 1 ;
        lastscore = Score ;
        
        }
    }
    IEnumerator Reload(){
      yield return new WaitForSeconds(10);
      SceneManager.LoadScene("Game");
    }
}

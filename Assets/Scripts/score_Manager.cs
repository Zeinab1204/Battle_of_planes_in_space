using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_Manager : MonoBehaviour
{
    public int Score = 0;

    public Text scoreText;
    public int highScore;

    void Start()
    {
        StartCoroutine(score());
        highScore = 0;
        Debug.Log("High Score stored :" + PlayerPrefs.GetInt("high_score",highScore));
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
            yield return new WaitForSeconds(3);
        Score = Score + 1 ;
        Debug.Log("Score:" + Score);
        }
    }
}

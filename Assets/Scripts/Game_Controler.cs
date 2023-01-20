using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controler : MonoBehaviour
{
    public Text highScoreText ;
    public Text scoreText;

    public int Score;
    public int highScore;

    public score_Manager score_manager;
    public GameObject gamePausePanel;
    public GameObject gamePauseButton;

    void Start()
    {
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        Score = score_manager.Score;

        highScoreText.text ="high Score:" + highScore.ToString();
        scoreText.text="Your Score" + Score.ToString(); 
    }
   public void Restart(){
        SceneManager.LoadScene("Game");
    }
    public void puaseGame(){
        Time.timeScale=0;
        gamePausePanel.SetActive(true);
        gamePauseButton.SetActive(false);
    }
      public void ResumeGame(){
        Time.timeScale=0;
         gamePausePanel.SetActive(false);
         gamePauseButton.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_Manager : MonoBehaviour
{
    public int Score = 0;

    public Text scoreText;

    void Start()
    {
        StartCoroutine(score());
    }

    // Update is called once per frame
    void Update()
    {
      scoreText.text= Score.ToString();
    }

    IEnumerator score(){
        while(true){
            yield return new WaitForSeconds(3);
        Score = Score + 1 ;
        Debug.Log("Score:" + Score);
        }
    }
}

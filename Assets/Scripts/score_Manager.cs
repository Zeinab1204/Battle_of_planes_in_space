using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_Manager : MonoBehaviour
{
    public int score = 0;
    void Start()
    {
        StartCoroutine(Score());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator Score(){
        while(true){
            yield return new WaitForSeconds(3);
        score = score + 1 ;
        Debug.Log("Score:" + score);
        }
    }
}

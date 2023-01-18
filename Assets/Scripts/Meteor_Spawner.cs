using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Spawner : MonoBehaviour
{
    public GameObject[] Meteor;
    void Start()
    {
       StartCoroutine(SpawnMeteor());
    }

    void Update()
    {
    
       

    }

    void meteor()
    {
        int rand =Random.Range(0,Meteor.Length);
        float randXPos= Random.Range(-2.17f,2.17f);
        Instantiate(Meteor[0],new Vector3(randXPos,transform.position.y,transform.position.z) ,Quaternion.identity);

    }
    IEnumerator SpawnMeteor(){
        while (true)
        {
         yield return new WaitForSeconds(4);
        meteor();   
        }
        
    }
}

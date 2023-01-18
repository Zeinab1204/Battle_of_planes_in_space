using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Spawner2 : MonoBehaviour
{
    public GameObject[] Aircraft;
    void Start()
    {
       StartCoroutine(SpawnAircraft());
    }

    void Update()
    {
    
       

    }

    void aircraft()
    {
        int rand =Random.Range(0,Aircraft.Length);
        float randXPos= Random.Range(-2.17f,2.17f);
        Instantiate(Aircraft[0],new Vector3(randXPos,transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,180));

    }
    IEnumerator SpawnAircraft(){
        while (true)
        {
         yield return new WaitForSeconds(6);
        aircraft();   
        }
        
    }
}

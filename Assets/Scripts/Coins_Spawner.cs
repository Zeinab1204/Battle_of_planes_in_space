using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin2_Spawner : MonoBehaviour
{
    public GameObject coin2Prefabs;

    void Start()
    {
        StartCoroutine(Coin2Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Coin2Spawn()
    {
        float rand= Random.Range(-2.17f,2.17f);
        Instantiate (coin2Prefabs,new Vector3(rand,transform.position.y,transform.position.z),Quaternion.identity);
    }
    IEnumerator Coin2Spawner(){
        while(true){
            int time =Random.Range(10,10);
            yield return new WaitForSeconds(time);
           Coin2Spawn();
        }
         
    }

}

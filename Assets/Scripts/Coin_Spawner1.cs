using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner1 : MonoBehaviour
{
    public GameObject coinPrefabs;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(CoinSpawner1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CoinSpawner()
    {
        float rand = Random .Range(-2.17f,2.17f);
        Instantiate(coinPrefabs,new Vector3 (rand,transform.position.y,transform.position.z),Quaternion.identity);
    }
    IEnumerator CoinSpawner1(){
        while(true){
            int time =Random.Range(4,7);
            yield  return new WaitForSeconds(time);
            CoinSpawner();
        }
    }
}

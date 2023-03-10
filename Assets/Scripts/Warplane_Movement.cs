using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warplane_Movement : MonoBehaviour
{
   public Transform Transform ;
   public float  speed = 0.1f ;
   public float rotationspeed = 5f ;
   public score_Manager score_Value ;
   public GameObject GameOverPanel;
   public AudioSource CoinSound;
    void Start()
    {
     GameOverPanel.SetActive(false);  
     Time.timeScale = 1;
     }

  
    void Update()
    {
      if(Input.GetKey(KeyCode.RightArrow)){
        transform.position += new Vector3(speed * Time.deltaTime ,0,0);
        transform.rotation=Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,-24),rotationspeed*Time.deltaTime);
      } 
      if(Input.GetKey(KeyCode.LeftArrow)){
        transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
        transform.rotation=Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,40),rotationspeed*Time.deltaTime);

      }
if(transform.rotation.z !=0){
    transform.rotation=Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,0),rotationspeed*Time.deltaTime);
}



      if(transform.position.x < -2.17f) {
        transform.position = new Vector3(-2.17f,transform.position.y ,Transform.position.z);
      }

      
      if(transform.position.x > 2.17f){
        transform.position = new Vector3(2.17f,transform .position.y,Transform.position.z);
      }
      }
      private void OnTriggerEnter2D(Collider2D collection){
        if(collection.gameObject.tag == "meteors"){
          Time.timeScale = 0;
          GameOverPanel.SetActive(true);
          Debug.Log("Oops, you hit it");
        Debug.Log(collection.gameObject.name);
        }
         if(collection.gameObject.tag == "Coin"){
          Destroy(collection.gameObject);
          CoinSound.Play();
          score_Value.Score +=10;
          Debug.Log("Very good");
            
        
         }
      }
}
    


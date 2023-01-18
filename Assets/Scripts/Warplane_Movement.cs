using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warplane_Movement : MonoBehaviour
{
   public Transform Transform ;
   public float  speed = 0.1f ;
    void Start()
    {
        
            }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.RightArrow)){
        Transform.position += new Vector3(speed * Time.deltaTime ,0,0);
      }  
      if(Input.GetKey(KeyCode.LeftArrow)){
        Transform.position -= new Vector3(speed * Time.deltaTime ,0,0);
      }
    }
    
}

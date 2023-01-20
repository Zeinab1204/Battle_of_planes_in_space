using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_aircraft_Movement : MonoBehaviour
{
public Transform Transform ;
 public float speed = 4f ;



    void Start()
    {
        
    }

   
    void Update()
    {
   transform.position -= new Vector3(0,speed * Time.deltaTime,0);
   if(transform.position.y <=-10){
    Destroy(gameObject);
   }
      
  }
 }

        
       

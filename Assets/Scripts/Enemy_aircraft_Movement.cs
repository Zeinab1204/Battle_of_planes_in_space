using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_aircraft_Movement : MonoBehaviour
{
public Transform Transform ;
 public float speed = 2f ;

    void Start()
    {
        
    }

   
    void Update()
    {
   Transform.position -= new Vector3(0,speed * Time.deltaTime,0);
    }
}

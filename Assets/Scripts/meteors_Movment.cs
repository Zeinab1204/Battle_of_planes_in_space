using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteors_Movment : MonoBehaviour
{
public Transform Transform ;
 public float speed = 2f ;

    void Start()
    {
        
    }

   
    void Update()
    {
   transform.position -= new Vector3(0,speed * Time.deltaTime,0);
          if (transform.position.y <=-30)
       {
        Destroy(gameObject);
       }
    }
}

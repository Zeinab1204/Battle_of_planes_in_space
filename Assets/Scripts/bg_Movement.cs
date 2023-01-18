using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_Movement : MonoBehaviour

{
   public Renderer meshRenderer;
   public float speed=1.4f;
    void Start()
    {
        
    }

    
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(0,speed*Time.deltaTime);
    }
}

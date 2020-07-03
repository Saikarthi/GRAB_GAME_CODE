﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{
    public float jump = 5f;
    public bool istouchground,isjump=false;
    public Transform groundcheckpoint;
    public float radius;
    public LayerMask groundlayer;
    public Rigidbody2D RigidBody;

    public Animator anim;
   

    void Start()
    {
        
    }
    
   
   
    void FixedUpdate()
    {
       
        istouchground = Physics2D.OverlapCircle(groundcheckpoint.position, radius, groundlayer);
        
        if (Input.GetButton("Jump") && istouchground)
        {
            isjump=true;
            
            Invoke("stopanim",0.5f);
            RigidBody.velocity = new Vector2(RigidBody.velocity.x, jump);
        }
        if(isjump==true)
            {
            anim.SetBool("idel",false);
            }
       
        if(isjump==false)
        {
            anim.SetBool("idel",true);
        }
        
        
        
    }

void stopanim()
{
    isjump=false;
}



   
}

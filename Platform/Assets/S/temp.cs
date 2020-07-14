﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class temp : MonoBehaviour
{
    public float heath;
    public float gameTime;
    public float startTime;
     public TextMeshProUGUI text,time;
     public bool check;
     
    // Start is called before the first frame update
    void Start()
    {
        heath =0;
        check =false;
        gameTime = 120;
    }
     void Awake()
         {
             startTime = Time.time;
         }

    // Update is called once per frame
    void Update()
    {
       
      text.SetText(heath.ToString("0"));

      //back time
       float elapsedTime = Time.time - startTime;
 
             int minutes = (int)((gameTime - elapsedTime) / 60) % 60;
             int seconds = (int)((gameTime - elapsedTime) % 60);
             string gameTimerString = string.Format("{0:0}:{1:00}", minutes, seconds);
           
                 time.SetText(gameTimerString.ToString());
             if (elapsedTime >= gameTime)
             {
                
                check =true;
             }
    
          
      

    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
     
       
       if(other.transform.tag=="good")
       {
           heath += 100;
       }
       if(other.transform.tag=="bad")
       {
           heath -= 50;
       }
       
    }
}

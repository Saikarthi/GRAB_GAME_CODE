using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temp : MonoBehaviour
{
    public float heath;
     public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        heath =50;
    }

    // Update is called once per frame
    void Update()
    {
        if(heath<=0)
        {
            heath = 0;
        }
        if(heath>=50)
        {
            heath =50;
        }
      slider.value =heath / 50;
    
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
     Debug.Log(other.transform.tag);
       
       if(other.transform.tag=="good")
       {
           heath += 5;
       }
       if(other.transform.tag=="bad")
       {
           heath -= 25;
       }
       
    }
}

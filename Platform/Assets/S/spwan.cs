using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject[] g;
    private int next=0, ran;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("st",1f,2f);
    }


     void st() 
    {
        
        ran = Random.Range(0,4);
        if(ran==next)
        {
             int ran = Random.Range(0,4);
        }
        next = ran;

         GameObject game =   Instantiate(g[ran],this.transform.position,Quaternion.identity);

         Destroy(game,10f);
    }
    
}

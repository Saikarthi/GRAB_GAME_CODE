using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject[] g;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("st",1f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void st() 
    {
        int ran = Random.Range(0,4);
            Instantiate(g[ran],this.transform.position,Quaternion.identity);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 v = new Vector3(-1,0,0);
            this.transform.position += speed * v * Time.deltaTime;
    }
}

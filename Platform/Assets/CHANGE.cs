using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHANGE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.transform.name);
        if(other.transform.tag!="Player")
        {
            Destroy(other.gameObject);
        }
    }
}

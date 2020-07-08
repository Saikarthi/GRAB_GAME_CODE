using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHANGE : MonoBehaviour
{
    private enemy e;

    public Sprite good;
       public Sprite bad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
       
        if(other.transform.tag!="player")
        {
            if(other.transform.tag=="good")
            {
                e =other.gameObject.GetComponent<enemy>();
                e.change(good);
            }
          if(other.transform.tag=="bad")
            {
                e =other.gameObject.GetComponent<enemy>();
                e.change(bad);
            }
        }
    }
}

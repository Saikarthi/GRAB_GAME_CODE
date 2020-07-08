using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float speed =4f;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
         spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 v = new Vector3(-1,0,0);
            this.transform.position += speed * v * Time.deltaTime;
    }

   public void change(Sprite snew)
   {
         spriteRenderer.sprite = snew; 
   }    
}

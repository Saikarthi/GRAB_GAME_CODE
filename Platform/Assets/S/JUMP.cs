using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }





    public void flip(float ha)
    {
        if (ha > 0 && !flipright || ha < 0 && flipright)
        {
            flipright = !flipright;
            Vector2 thescale = transform.localScale;
            thescale.x *= -1;
            transform.localScale = thescale;
        }
    }
}

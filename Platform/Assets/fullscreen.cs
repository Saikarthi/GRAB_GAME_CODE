using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullscreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
             if (Application.platform == RuntimePlatform.Android)
            {
                Screen.fullScreen = true; 
            }
            else if(Application.platform == RuntimePlatform.IPhonePlayer)
            {
                 Screen.fullScreen = true; 
            }
    }
}

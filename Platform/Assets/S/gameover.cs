using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject game ,h;
    public temp t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t.check)
        {
           
            game.SetActive(true);
            h.SetActive(false);
        }

    }
   public void restart()
    {
        SceneManager.LoadScene(1);
    }
}

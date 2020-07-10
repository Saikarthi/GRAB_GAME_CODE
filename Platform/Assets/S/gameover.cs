using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject game;
    public temp t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t.heath<=0)
        {
           
            game.SetActive(true);
        }

    }
   public void restart()
    {
        SceneManager.LoadScene(1);
    }
}

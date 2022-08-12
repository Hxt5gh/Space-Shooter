using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    private void Awake()
    {

        int numoFMusic = FindObjectsOfType<MusicPlayer>().Length;
        print(numoFMusic);
        if(numoFMusic > 1)
        {
            Destroy(gameObject);
        }
        else
        {
         DontDestroyOnLoad(gameObject);
        }



    }
    void Start()
    {

        Invoke("LoadMainLevel", 8f);
        

    }

 
 

    void LoadMainLevel()
    {


        SceneManager.LoadScene(1);
       
    }

}

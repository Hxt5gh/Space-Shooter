using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollegionManager : MonoBehaviour
{

    public GameObject Explosionpartical;
  
    void OnTriggerEnter(Collider other)
    {

       print("trigger hapened" + other.name + "hitted");
        DeathSequence();
        Explosionpartical.SetActive(true);
        // Invoke(" loadRestart",0f);
        loadRestart();
    }

    private void    DeathSequence()
    {
      
        //  SendMessage("OnDead");

    }
     





   public  void   loadRestart()
    {
        SceneManager.LoadScene(1);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject blastEffect;


     void OnParticleCollision(GameObject other)
    {
       print(gameObject.name);
       Instantiate(blastEffect,transform.position, Quaternion.identity);
        Destroy(gameObject);
      
       
    }
    private void Start()
    {
        AddNonTriggerBoxCollider();
        
    }

    private void AddNonTriggerBoxCollider()
    {
       Collider colider = gameObject.AddComponent<BoxCollider>();
        colider.isTrigger = false;
        gameObject.AddComponent<BoxCollider>();

    }
}

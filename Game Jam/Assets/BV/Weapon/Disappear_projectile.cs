using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Disappear_projectile : MonoBehaviour
{      
      void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if(col.gameObject.CompareTag("Aim") && col.gameObject.CompareTag("Player")){
            Physics.IgnoreCollision(col.collider , gameObject.GetComponent<Collider>());            
        }        
        //despawn target
        if(col.transform.root.CompareTag("Wall")){
            Destroy(gameObject);
        }        
    }
}

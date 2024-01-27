using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear_projectile : MonoBehaviour
{
      void OnCollisionEnter(Collision col)
    {
        //despawn projectile
        if (col.gameObject.CompareTag("Target"))
        {
            Debug.Log("Collision Detected");
            Destroy(col.gameObject);
        
            //despawn target
            Debug.Log("Target Hit");
            Destroy(gameObject);
        }
    }
}

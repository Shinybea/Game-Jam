using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //despawn projectile
        if (col.gameObject.CompareTag("Destroyer"))
        {
            Debug.Log("Inmovable object");
            Destroy(gameObject);
        }
    }
}

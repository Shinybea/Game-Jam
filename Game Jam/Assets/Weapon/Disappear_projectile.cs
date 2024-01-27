using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear_projectile : MonoBehaviour
{
    public GameObject p3;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            Debug.Log("Collision Detected");
            Destroy(p3);
        }
    }
}

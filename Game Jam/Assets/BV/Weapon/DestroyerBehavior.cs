using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehavior : MonoBehaviour
{
    public AudioSource[] sounds;
    IEnumerator audioKill(){

        UnityEngine.Random.Range(0 , sounds.Length);
        yield return new WaitForSeconds(1);
    }
    void OnCollisionEnter(Collision col)
    {
        //despawn projectile
        if (col.gameObject.CompareTag("Bambino"))
        {
            Debug.Log("Inmovable object");
            Destroy(col.gameObject);
            StartCoroutine(audioKill());
        }
    }
}

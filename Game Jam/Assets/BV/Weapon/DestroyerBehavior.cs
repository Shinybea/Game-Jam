using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehavior : MonoBehaviour
{
    public AudioSource[] sounds;
    IEnumerator audioKill(){

        int rand = UnityEngine.Random.Range(0 , sounds.Length);
        sounds[rand].Play();
        yield return new WaitForSeconds(sounds[rand].clip.length);
    }
    void OnCollisionEnter(Collision col)
    {
         if(col.transform.root.CompareTag("Wall")){
            Destroy(gameObject);
        }
        //despawn projectile
        if (col.gameObject.CompareTag("Bambino"))
        {
            Debug.Log("Inmovable object");
            Destroy(col.gameObject);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            StartCoroutine(audioKill());
        }
    }

    void Start(){
        sounds = GetComponents<AudioSource>();
    }
}

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
        if (col.gameObject.CompareTag("Bambino"))
        {
            Debug.Log("Collision Detected");
            Destroy(col.gameObject);
            PlayerPrefs.SetInt("score",PlayerPrefs.GetInt("score")+1);
            Debug.Log(PlayerPrefs.GetInt("score"));
            //despawn projectile
            Debug.Log("Target Hit");
            Destroy(gameObject);
        }
    }
}

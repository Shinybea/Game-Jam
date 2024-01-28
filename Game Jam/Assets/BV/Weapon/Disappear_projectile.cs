using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear_projectile : MonoBehaviour
{

      void OnCollisionEnter(Collision col)
    {
        //despawn target
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

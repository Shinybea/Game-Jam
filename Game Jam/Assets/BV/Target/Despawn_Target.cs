using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Despawn_Target : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Projectile")
        {
            //despawn target
            {
                Destroy(this.gameObject);
            }
        }
    }
}

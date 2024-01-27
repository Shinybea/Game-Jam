using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Launch_projectile : MonoBehaviour
{   
    //launch
    public GameObject projectile;
    public float launchVelocity = 700f;
    //cooldown timer
    public float timer = 0;
    public bool check = false;
    public double cooldown = 0.5;

    void Update()
    {
        //timer
        if (check)
            {
            timer += Time.deltaTime;    
            }

        //fire bullet
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("hosparato");

            //shoot then cooldown
            if (!check)
            {
                check = true;
                GameObject ball = Instantiate(projectile, transform.position,
                                                          transform.rotation);
                ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                               (0, launchVelocity, 0));
            }
            //shoot again
            if (check && timer > cooldown)
            {
                check = false;
                GameObject ball = Instantiate(projectile, transform.position,
                                                          transform.rotation);
                ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                               (0, launchVelocity, 0));
                timer = 0;
                //reset cooldown
                check = true; 
                

            }


        }
        
    }
    
   
}

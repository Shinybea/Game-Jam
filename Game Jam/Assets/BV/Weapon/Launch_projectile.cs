using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
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
    public Camera mainCam;
    public Vector3 mousePos;

    void Start(){
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
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
                GameObject ball = Instantiate(projectile, transform.position, Quaternion.identity);
                mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
                Vector3 direzione = mousePos - transform.position;
                ball.GetComponent<Rigidbody>().velocity = -direzione*10;
            }
            //shoot again
            if (check && timer > cooldown)
            {
                check = false;
                GameObject ball = Instantiate(projectile, transform.position, Quaternion.identity);
                mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
                Vector3 direzione = mousePos - transform.position;
                ball.GetComponent<Rigidbody>().velocity = -direzione*10;
                timer = 0;
                //reset cooldown
                check = true; 
            }        
        }
    }
}

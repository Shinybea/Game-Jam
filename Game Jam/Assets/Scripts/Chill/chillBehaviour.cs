using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chillBehaviour : MonoBehaviour
{
    public bool chill = true;
    public GameObject target;
    private SpawnerScript spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GetComponent<SpawnerScript>();
        spawner.abled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            spawner.abled = true;
            chill = false;
            Variables.Application.Set("chill" , false);
        }        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chillBehaviour : MonoBehaviour
{
    public bool chill = true;
    public GameObject target;
    public GameObject[] lights;
    private SpawnerScript spawner;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score" , 0);
        spawner = GetComponent<SpawnerScript>();
        spawner.abled = false;
        lights = GameObject.FindGameObjectsWithTag("Light");
        activeLights(false);
    }

    public void activeLights(bool active){
        for(int i = 0; i < lights.Length; i++){
            lights[i].SetActive(active);
        }
    }

    public IEnumerator startLights(){
        yield return new WaitForSeconds(5);        
        activeLights(true);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            StartCoroutine(startLights());
            spawner.abled = true;
            chill = false;            
            Variables.ActiveScene.Set("chill" , chill);            
        }        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public int maxMob = 15;
    public int totMob = 0;
    public float spawnRate = 1f;
    public GameObject bambino;
    public float timer = 0;
    public GameObject[] spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectsWithTag("Spawner");
        StartCoroutine(spawner());
    }

    public IEnumerator spawner(){
        while(true){
            yield return new WaitForSeconds(spawnRate);
            totMob = GameObject.FindGameObjectsWithTag("Bambino").Length;
            Debug.Log(totMob);            
            if(totMob < maxMob){
                int rand = UnityEngine.Random.Range(0 , spawn.Length);
                Instantiate(bambino , spawn[rand].transform.position,Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

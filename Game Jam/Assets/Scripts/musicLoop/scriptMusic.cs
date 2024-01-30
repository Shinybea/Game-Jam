using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptMusic : MonoBehaviour
{

    public chillBehaviour chill;
    public bool check = false;
    public AudioSource[] audios;
    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponents<AudioSource>();
        chill = GetComponent<chillBehaviour>();        
        audios[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(audios.Length);
        if(Input.GetButtonDown("Fire1") && !check){
            audios[0].Stop();            
            audios[1].Play();
            check = true;
        }

    }
}

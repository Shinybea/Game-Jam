using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptMusic : MonoBehaviour
{

    public chillBehaviour chill;
    public AudioSource[] audios;
    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponents<AudioSource>();
        chill = GetComponent<chillBehaviour>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(chill.chill){
            audios[0].Stop();
            audios[1].Play();
        }
    }
}

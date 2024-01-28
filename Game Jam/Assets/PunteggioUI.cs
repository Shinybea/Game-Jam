using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PunteggioUI : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.GetInt("score").Equals(0)){
            GetComponent<TextMeshProUGUI>().text = "Punteggio: " + PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score",0);
        } else {
            GetComponent<TextMeshProUGUI>().text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

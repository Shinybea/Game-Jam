using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliceLights : MonoBehaviour
{
    public Light policeLight;
    public Color first;
    public Color second;
    public Transform parent;
    public float timer = 0;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        policeLight = GetComponent<Light>();
        StartCoroutine(flashLight());
        parent = GetComponentInParent<Transform>();
        Debug.Log(parent.position);
        StartCoroutine(startMoving());
    }

    public IEnumerator flashLight(){
        while(true){
            policeLight.color = first;
            yield return new WaitForSeconds(1);
            policeLight.color = second;
            yield return new WaitForSeconds(1);
        }
    }

    public IEnumerator endGame(){
        Debug.Log("Ending");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("UI");
    }

    public IEnumerator startMoving(){
        Debug.Log("startMoving");
        yield return new WaitForSeconds(5);
        speed = 0.5f; 
    }
    // Update is called once per frame
    void Update()
    {
        if(parent.position.Equals(new Vector3(-7 , 16 , -13))){
            StartCoroutine(endGame());
        }
        transform.Rotate(0 , 2, 0 , Space.World);
        parent.position = Vector3.MoveTowards(parent.position , new Vector3(-7 , 16, -13) , speed * Time.fixedDeltaTime);            
    }
}

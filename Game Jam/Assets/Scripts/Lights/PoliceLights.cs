using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceLights : MonoBehaviour
{
    public Light policeLight;
    public Color first;
    public Color second;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        policeLight = GetComponent<Light>();
        StartCoroutine(flashLight());
        parent = GetComponentInParent<Transform>();
        Debug.Log(parent.position);
    }

    public IEnumerator flashLight(){
        while(true){
            policeLight.color = first;
            yield return new WaitForSeconds(1);
            policeLight.color = second;
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , 2, 0 , Space.World);
        parent.position = Vector3.MoveTowards(parent.position , new Vector3(-7 , 16, -13) , 2f * Time.fixedDeltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveTest : MonoBehaviour
{
    
    public Vector3 pointB;
    public float speed = 1.0f;

    IEnumerator Start()
    {
        //move from start to PointB and go back
        var pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, speed));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, speed));
        }
    }
    IEnumerator MoveObject(Transform thisTransform, Vector3 pointA, Vector3 pointB, float time)
         {
        Debug.Log("StartCoroutine");
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(pointA, pointB, i);
            yield return null;
        }
    }
   

}
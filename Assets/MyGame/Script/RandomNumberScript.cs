using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberScript : MonoBehaviour
{

    private void Start()
    {
        float randomValue = UnityEngine.Random.value;
        Debug.Log(randomValue+ ("Random Value"));


        transform.position = UnityEngine.Random.insideUnitSphere * 5;
        Debug.Log(transform.position + "Transform Position");

        transform.rotation = UnityEngine.Random.rotation;
        Debug.Log(transform.rotation + "Rotation");
    }
}
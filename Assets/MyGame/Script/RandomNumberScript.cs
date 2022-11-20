using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberScript : MonoBehaviour
{

    private void Start()
    {
        float randomValue = UnityEngine.Random.value;
        Debug.Log(randomValue);


        transform.position = UnityEngine.Random.insideUnitSphere * 5;
        Debug.Log(transform.position + "Transform Position");

        GetComponent<Rigidbody>().velocity = Random.onUnitSphere * 10;
        Debug.Log()
    }
}
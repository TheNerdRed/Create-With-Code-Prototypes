using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float firstSpeedRange = 8f; 
    public float secondSpeedRange = 20f;

    // Update is called once per frame
    void Update()
    {
        float speed = Random.Range(firstSpeedRange, secondSpeedRange);
        Debug.Log(speed);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Point : MonoBehaviour
{
    public Transform target;    // sun 
    public int speed;           // the speed of orbit rotation 

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}

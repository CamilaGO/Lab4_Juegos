using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowser : MonoBehaviour
{
    public int speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(transform.position, Vector3.left, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
    }
}

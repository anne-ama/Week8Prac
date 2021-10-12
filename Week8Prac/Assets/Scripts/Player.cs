using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 velocity = new Vector3(0,0,5);
    public float rotation = 30;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        //up, down, left and right (using input Axes script)
        float adKeys = Input.GetAxis(InputAxes.Horizontal);
        float wsKeys = Input.GetAxis(InputAxes.Vertical);
        
        transform.Translate(velocity * Time.deltaTime*wsKeys);
        float angle = rotation * Time.deltaTime;
        transform.Rotate(angle * Vector3.up*adKeys);
    }
}

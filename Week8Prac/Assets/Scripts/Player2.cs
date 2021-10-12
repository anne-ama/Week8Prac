using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private Vector3 velocity = new Vector3(0,0,5);
    public float rotation = 30;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        //up, down, left and right (using input Axes script)
        float horizontalKeys = Input.GetAxis(InputAxes.ArrowHorizontal);
        float verticalKeys = Input.GetAxis(InputAxes.ArrowVertical);
        
        transform.Translate(velocity * Time.deltaTime*verticalKeys);
        float angle = rotation * Time.deltaTime;
        transform.Rotate(angle * Vector3.up*horizontalKeys);
    }
}

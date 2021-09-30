using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        private Vector3 velocity = new Vector3(0,0,5);
        public float rotation = 30;
        public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        transform.Translate(velocity * Time.deltaTime*dy);
        float angle = rotation * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(0,transform.rotation.y,0);
        transform.Rotate(angle * Vector3.up*dx);
        Debug.Log(transform.rotation);
        //transform.rotation.x=0;
        //if(transform.rotation.x!=0)
        {
        //    transform.Rotate(transform.rotation.x*Vector3.right);
        }
        //if(transform.rotation.z!=0)
        {
//        transform.Rotate(transform.rotation.z*Vector3.forward);
        }
        //transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
    }
}

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
        transform.Rotate(angle * Vector3.up*dx);
        float rot = transform.rotation.y;
        transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
transform.rotation = Quaternion.Euler(0,rot,0);
    }
}

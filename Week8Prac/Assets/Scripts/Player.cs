using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 velocity = new Vector3(0,0,5);
    public float rotation = 30;
    public float speed = 1;
    public ScoreKeeper keeper;
    public Coin coin;

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        transform.Translate(velocity * Time.deltaTime*dy);
        float angle = rotation * Time.deltaTime;
        transform.Rotate(angle * Vector3.up*dx);
    }
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        string objectName = other.gameObject.name.Substring(0, coin.name.Length + 1);
        if(objectName == coin.name + " "||objectName == coin.name)
        {
            keeper.AddScore();
        }

    }

}

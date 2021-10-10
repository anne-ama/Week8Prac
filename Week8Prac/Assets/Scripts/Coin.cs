using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotation = 30;
    public Player player1;
    private BoxCollider BC;
    public ScoreKeeper keeper;
    //public AudioClip collect;

    // Start is called before the first frame update
    void Start()
    {
        BC = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = rotation * Time.deltaTime;
        transform.Rotate(angle * Vector3.up);
    }
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        string objectName = other.gameObject.name;
        if(objectName.Length > player1.name.Length)
        {
            objectName = objectName.Substring(0, player1.name.Length + 1);
        }
        Debug.Log(player1.name + " & " + objectName + ".");
        if(objectName == player1.name + " "||objectName == player1.name)
        {
            keeper.AddScore();

            Destroy(gameObject);
        }

    }

}

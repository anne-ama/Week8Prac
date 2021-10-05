using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotation = 30;
    public Player player;
    private BoxCollider BC;
    public ScoreKeeper keeper;


    // Start is called before the first frame update
    void Start()
    {
        BC = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = rotation * Time.deltaTime;
        transform.Rotate(angle * Vector3.forward);
    }
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        string objectName = other.gameObject.name.Substring(0, player.name.Length + 1);
        Debug.Log(player.name + " & " + objectName + ".");
        if(objectName == player.name + " "||objectName == player.name)
        {
            keeper.AddScore();
            Destroy(gameObject);
        }

    }

}

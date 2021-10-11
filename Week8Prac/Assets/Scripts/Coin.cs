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
        transform.Rotate(angle * Vector3.up);
    }
    void OnTriggerEnter(Collider collider)
    {
        // GameObject other = collider.gameObject;
        // string objectName = other.gameObject.name;
        // if(objectName.Length > player.name.Length)
        // {
        //     objectName = objectName.Substring(0, player.name.Length + 1);
        // }
        // Debug.Log(player.name + " & " + objectName + ".");
        if(collider.gameObject.CompareTag("Player1") || collider.gameObject.CompareTag("Player2"))
        {
            keeper.AddScore();
            Destroy(gameObject);
        }

    }

}

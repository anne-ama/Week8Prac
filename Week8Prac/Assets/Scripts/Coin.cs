using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotation = 30;
    public Player player;
    private BoxCollider BC;
    public ScoreKeeper keeper;
    public ScoreKeeperP2 keeperP2;

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
        if(collider.gameObject.CompareTag("Player1"))
        {
            keeper.AddScore();
            Destroy(gameObject);
        }

        if (collider.gameObject.CompareTag("Player2"))
        {
            keeperP2.AddScore();
            Destroy(gameObject);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [Range(1, 10)]
    public int pointsPerPickup = 10;
    private int score = 0;
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("There is no Scorekeeper in the scene");
            }
            return instance;
        }
    }

    void OnAwake()
    {
        if (instance != null)
        {
            Debug.Log("There is more than one Scorekeeper in the scene");
        }
        instance = this;
    }

    public void AddScore()
    {
        score += pointsPerPickup;
    }

    public int GetScore()
    {
        return score;
    }
}

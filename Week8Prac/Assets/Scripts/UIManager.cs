using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    private int n;
    public ScoreKeeper scoreKeeper;
    
    // Update is called once per frame
    void Update()
    {
        n = scoreKeeper.GetScore();
        scoreText.text = "" + n ;
    }
}

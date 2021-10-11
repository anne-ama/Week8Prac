using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextP2;
    private int n1;
    private int n2;
    public ScoreKeeper scoreKeeper;
    public ScoreKeeperP2 scoreKeeperP2;
    // Update is called once per frame
    void Update()
    {
        //Player1
        n1 = scoreKeeper.GetScore();
        scoreText.text = "" + n1 ;

        //Player2
        n2 = scoreKeeperP2.GetScore();
        scoreTextP2.text = "" + n2;
    }
}

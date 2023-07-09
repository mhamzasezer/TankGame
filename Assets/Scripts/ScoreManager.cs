using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{   
    public Text scoreLabel;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel.text = "SCORE:" + score;
    }

    public void AddScore(int amount){
        score += amount;
        scoreLabel.text = "SCORE:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

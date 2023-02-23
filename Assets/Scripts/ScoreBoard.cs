using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public int lives = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int value) {
        score += value;
    }
    public void UpdateLives(int value) {
        lives += value;
    }
}

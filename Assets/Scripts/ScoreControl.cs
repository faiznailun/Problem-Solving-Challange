using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float GetCurrentScore()
    {
        return score;
    }
    public void IncrementScore()
    {
        score++;
    }
    public int Score
    {
        get { return score; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

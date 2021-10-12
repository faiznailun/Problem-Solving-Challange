using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreControl : MonoBehaviour
{
    public Text score;
    public ScoreControl scoreControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        score.text = scoreControl.GetCurrentScore().ToString();
    }
}

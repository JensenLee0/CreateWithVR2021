using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TVCanvasControl : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreDisplay();
    }
    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = $"Score: {score}";
    }
    public void AddToScore()
    {
        score++;
        UpdateScoreDisplay();
    }
}
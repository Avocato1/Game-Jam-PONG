using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    private int p1Score = 0; 
    private int p2Score = 0; 

    [SerializeField] private TextMeshProUGUI p1ScoreText;
    [SerializeField] private TextMeshProUGUI p2ScoreText;

    void Start()
    {
        
        UpdateScoreText();
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            p2Score += 1;
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            p1Score += 1;
        }

       
        UpdateScoreText();
    }
    
    private void UpdateScoreText()
    {
        p1ScoreText.text = "" + p1Score;
        p2ScoreText.text = "" + p2Score;
    }
}
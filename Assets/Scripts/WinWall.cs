using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinWall : MonoBehaviour
{
    int score = 0;    
    [SerializeField]
    Ball ball;    
    [SerializeField]
    TMP_Text text;

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log(col);
        score += 1;
        text.text = score.ToString();

        ball.Reset();
    }
}

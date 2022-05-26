using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public int Score { get; set; }

    private void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
    }
}

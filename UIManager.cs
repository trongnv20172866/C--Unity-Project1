using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject GameOverPanel; // doi tuong trong game

    public void SetScoreText(string txt)
    {
        if (ScoreText)
            ScoreText.text = txt;
    }
    public void ShowGameoverPanel(bool isShow)
    {
        if (GameOverPanel)
            GameOverPanel.SetActive(isShow);
    }
}

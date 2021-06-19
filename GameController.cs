using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;

    UIManager m_ui;

    int m_score;
    bool m_isGameover;
    // Start is called before the first frame update
    void Start()
    {
       m_spawnTime = 0;
       m_ui = FindObjectOfType<UIManager>();
       m_ui.SetScoreText("Score: " + m_score);
    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-10, 10), 10);
        if(ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_isGameover)
        {
            m_spawnTime = 0;
            m_ui.ShowGameoverPanel(true);
            return;
        }

        if(m_spawnTime <= 0)
        {
            SpawnBall();

           m_spawnTime = spawnTime;
        }
    }

    public void Relay()
    {
        m_score = 0;
        m_isGameover = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameoverPanel(false);
    }

    public void SetScore(int value)
    {
        m_score = value;
    }
    public int GetScore()
    {
        return m_score;
    }
    public void IncrementScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public bool isGameover()
    {
        return m_isGameover;
    }
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }
}

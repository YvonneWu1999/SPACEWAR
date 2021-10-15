using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public Text scoreText;
    public Text lifeText;
    int score;
    int life;
    // Use this for initialization
    void Start()
    {
        score = 0;
        life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            GameOverScreen.Setup(score);
        }
    }
    public int getScore()
    {
        return score;
    }
    public void addScore(int n)
    {
        score += n;
        scoreText.text = "Score : " + score;
    }
    public void reduceLife(int n)
    {
        life -= n;
        lifeText.text = "Life : " + life;
    }
}

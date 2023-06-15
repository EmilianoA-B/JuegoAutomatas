using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LogicCode : MonoBehaviour
{
    public Text scoreUI;
    public Text highScore;
    public BallBehaviour ball;
    public GameObject gameOver;
    public Button RetryButton;
    public Button MenuButton;
    public int  score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = "0";
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallBehaviour>();
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("addPoint")]
    public void addPoint()
    {
        score++;
        scoreUI.text = score.ToString();
        checkHighscore();
    }

    public void GameOver()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        gameOver.SetActive(true);
        ball.ballisDead();
    }

    public void restartGame()
    {
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void checkHighscore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            highScore.text = score.ToString(); 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicCode : MonoBehaviour
{
    public BallBehaviour ball;
    public GameObject gameOver;
    public Button RetryButton;
    public Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").GetComponent<BallBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        ball.ballisDead();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

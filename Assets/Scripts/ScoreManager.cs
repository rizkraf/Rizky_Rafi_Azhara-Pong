using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    public BallController ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddRightScore(int increment, bool isRight)
    {
        rightScore += increment;
        ball.ResetBall(isRight);

        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increment, bool isRight)
    {
        leftScore += increment;

        ball.ResetBall(isRight);

        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

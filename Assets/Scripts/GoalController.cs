using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddLeftScore(1, isRight);
            }
            else
            {
                manager.AddRightScore(1, isRight);
            }
        }
    }
}

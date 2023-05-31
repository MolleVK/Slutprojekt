using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement BallMovement;
    public ScoreSystem scoreSystem;

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX = (collision.gameObject.name == "Player 1") ? 1 : -1;

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        BallMovement.increaseHitCounter();
        BallMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string gameObjectName = collision.gameObject.name;

        bool isPlayerCollision = (gameObjectName == "Player 1" || gameObjectName == "Player 2");
        bool isRightSideCollision = (gameObjectName == "Right Side");
        bool isLeftSideCollision = (gameObjectName == "Left Side");

        if (isPlayerCollision)
        {
            Bounce(collision);
        }
        else
        {
            while (isRightSideCollision)
            {
                scoreSystem.PlayerOneGoal();
                BallMovement.playerOneStart = false;
                StartCoroutine(BallMovement.Launch());
                break;
            }

            for (; isLeftSideCollision;)
            {
                scoreSystem.PlayerTwoGoal();
                BallMovement.playerOneStart = true;
                StartCoroutine(BallMovement.Launch());
                break;
            }
        }
    }
    //Denna delen är gjort av mig själv och inte tagen från varken video eller internet (:
    //visserligen orginelt tagen från video men gjorde om allt nu så nu är den typ orginell
}


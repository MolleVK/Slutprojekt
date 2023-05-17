using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement BallMovement;

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if (collision.gameObject.name == "PlayerOne")
        {
            positionX = 1;
        }

        else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        BallMovement.increaseHitCounter();
        BallMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void CollisionCheck(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerOne" || collision.gameObject.name == "PlayerTwo")
        {
            Bounce(collision);
        }
    }
}

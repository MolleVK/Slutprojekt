using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;

    public bool playerOneStart = true;

    private int hitCounter = 0;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }

    public IEnumerator Launch()
    {
        RestartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);

        if (playerOneStart == true)
        {
            MoveBall(new Vector2(-1, 0));
        }

        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed = startSpeed + hitCounter * extraSpeed;

        rb.velocity = direction * ballSpeed;
    }

    public void increaseHitCounter()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
}

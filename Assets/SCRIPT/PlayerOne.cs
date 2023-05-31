using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public float racketSpeed;

    private Rigidbody2D rb;
    private Vector2 racketDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");

        racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;
    }

}

//B�de player one och two �r tagna fr�n video men fick lov att �ndra m�nga delar av koden d� rackets inte originellt fungera, tyv�rr har jag inga notes p� vad dessa �ndringar var..
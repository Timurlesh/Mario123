using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private rigidbody2D rb;
    private float horizontal;
    private bool flipRight = true;

    public float horizontal { get => horizontal; set => horizontal = value; }

    void Start()
    {
        rb = GetComponent<rigidbody2D>();
    }
        

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("horizontal");
        rb.velocity = new Vector2(horizontal,rb.velocity.y);
        if (horizontal > 0 && !flipRight)
        {
            Flip();
        }
        else if (horizontal < 0 && flipRight)
        {
            Flip();
        }
    }
    void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * (-1);
        transform.localScale = theScale;
    }
}


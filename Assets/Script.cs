using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody2D rb;
    private float horizontal;
    private bool flip = true;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
        

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed,rb.velocity.y);
        animator.SetFloat("moveX", Mathf.Abs(horizontal));
/*      if (horizontal > 0 && !flipRight)
        {
            Flip();
        }else if (horizontal < 0 && flipRight)
        {
            Flip();
        }*/
        if((horizontal > 0 && !flip) || (horizontal < 0 && flip))
        {
            transform.localScale *= new Vector2(-1, 1);
            flip = !flip;
        }
    }
    /*
    void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * (-1);
        transform.localScale = theScale;
    }
    */
}


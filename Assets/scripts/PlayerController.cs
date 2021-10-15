using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceValue = 2f;
    Rigidbody2D rbody2D;
    private Animator animator;
    private bool isFacingRight = true;  // For determining which way the player is currently facing.
    // Use this for initialization
    void Start()
    {
        rbody2D = this.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetInteger("state", 2);
        }
        Vector2 force2D = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("state", 0);
            force2D.y += forceValue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("state", 0);
            force2D.y -= forceValue;
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("state", 1);
            force2D.x -= forceValue;
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("state", 1);
            force2D.x += forceValue;
        }
        if (dirx > 0 && !isFacingRight)
        {
            FlipSprite();
        }
        else if (dirx < 0 && isFacingRight)
        {
            FlipSprite();
        }
        if (dirx * transform.localScale.x < 0)
        {
            // transform.rotation = Quaternion.Euler(0, 180, 0);
            // transform.Rotate(0f, 180f, 0f);
            // this.transform.localScale = new Vector3(-1 * this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        }
        rbody2D.AddForce(force2D);
    }
    void FlipSprite()
    {
        isFacingRight = !isFacingRight;
      
        transform.Rotate(0f, 180f, 0f);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameObject.SetActive(false); 讓物體消失
        GameObject.Find("GameManager").GetComponent<GameManager>().reduceLife(1);
        if (collision.name == "shot" || collision.name== "shot2")
        {
            collision.transform.position = new Vector3(7.54f, collision.transform.position.y, collision.transform.position.z);
        }
        else
        {
            collision.transform.position = new Vector3(10, collision.transform.position.y, collision.transform.position.z);
        }
       
    }
}

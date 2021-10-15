using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleController : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.name != "Background")
        {

            if (collision.name == "shot" || collision.name == "shot2")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().addScore(100);
                collision.transform.position = new Vector3(7.54f, collision.transform.position.y, collision.transform.position.z);
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().addScore(50);
                collision.transform.position = new Vector3(20, collision.transform.position.y, collision.transform.position.z);
            }
           
        }
        Destroy(gameObject);

    }


    
}

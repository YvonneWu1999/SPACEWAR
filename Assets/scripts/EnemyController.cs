using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().getScore() > 1000)
        {
            speed = 3;
        }
        this.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        // this.transform.Rotate(new Vector3(0f, 0f, 1f), 5);
        if (this.transform.position.x < -10)
        {
            this.transform.position = new Vector3(10f, this.transform.position.y, this.transform.position.z);
        }
    }
}

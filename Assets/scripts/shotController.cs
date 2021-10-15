using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour
{
    public float speed = 3;
    float p = 0;
    // Start is called before the first frame update
    void Start()
    {
        p = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
        // this.transform.Rotate(new Vector3(0f, 0f, 1f), 5);
        if (this.transform.position.x < -10)
        {
            this.transform.position = new Vector3(p, this.transform.position.y, this.transform.position.z);
        }
    }
}

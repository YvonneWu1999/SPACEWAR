using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject misslePrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
       
    }
    void Shoot()
    {
        Instantiate(misslePrefab, firePoint.position, firePoint.rotation);
        // shooting logic
    }
}

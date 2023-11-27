using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireBall;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")){

            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(fireBall, firePoint.position, firePoint.rotation);
    }
}

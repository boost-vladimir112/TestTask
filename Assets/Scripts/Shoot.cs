using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject posBullet;

    public float fireRate = 15f;
    private float nextTimeToFire = 0f;


    // Update is called once per frame
    void Update()
    {
       if(Input.anyKeyDown && Time.time > nextTimeToFire)
        {
            nextTimeToFire = Time.time +1f / fireRate;
            Shooting();
        }
    }
    void Shooting()
    {
        GameObject bulletObj = Instantiate(bulletPrefab);
        bulletObj.transform.position = posBullet.transform.position + posBullet.transform.forward;
        bulletObj.transform.forward = posBullet.transform.forward;
    }
}

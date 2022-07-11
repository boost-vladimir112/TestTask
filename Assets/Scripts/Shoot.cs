using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject posBullet;

    public float fireRate = 15f;
    private float nextTimeToFire = 0f;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);
        if (Input.anyKeyDown && Time.time > nextTimeToFire)
        {
            nextTimeToFire = Time.time +1f / fireRate;
            Shooting();
        }
    }
    void Shooting()
    {
        if (Input.anyKeyDown)
        {
            RaycastHit hit;
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit))
            {
                GameObject bulletObj = Instantiate(bulletPrefab);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                bulletObj.transform.position =  hit.point;
                bulletObj.transform.forward = posBullet.transform.forward;
            }
            

            //bulletObj.transform.position = posBullet.transform.position;
            //bulletObj.transform.forward = posBullet.transform.forward;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 65f;
    Rigidbody rb;
    public float lifeTimer = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if(lifeTimer < 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy (gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(1);
        }
    }
}

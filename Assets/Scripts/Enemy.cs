using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    Animator anim;

    public int health = 3;
    [SerializeField]
    private Text hpText;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            anim.enabled = false;
            Ragdoll();
            
            //Destroy(gameObject);
        }
        hpText.text = health.ToString() + "HP";
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public void Ragdoll()
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = false;
        }
    }
}

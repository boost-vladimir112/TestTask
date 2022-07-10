using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    [SerializeField]
    private Text hpText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        hpText.text = health.ToString() + "HP";
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{

    public bool isPlayerHere = false;
    //public BoxCollider boxCollider;
    public PlayerController playerController;
    
    private void OnTriggerStay(Collider other)
    {
        
        if(other.TryGetComponent<Enemy>(out Enemy enemy) && isPlayerHere)
        {
            if(other.GetComponent<Enemy>().isDead )
            {
                //Debug.Log(other.name);
                playerController._fight = false;
            }
            else if(!other.GetComponent<Enemy>().isDead)
            {
                //Debug.Log(other.name);
                playerController._fight = true;
            }
           
 
        }
     

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        if (other.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            isPlayerHere = true;
            Debug.Log(other.name);
            other.GetComponent<PlayerController>()._fight = true;
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    private List<Enemy> war;
    public void RemoveFromList(Enemy enemytoremove)
    {
        war.Remove(enemytoremove);
     

    }
    public void StopFight()
    {
        if (war.Count <= 0)
        {
            GetComponent<Animation>().RunAnim();
        }
    }
    public void AddToList(Enemy enemytoremove)
    {
        if (war == null)
        {
            war = new List<Enemy>();
        }
    }
}

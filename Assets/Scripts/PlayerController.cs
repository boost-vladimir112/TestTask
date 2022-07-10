using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool _fight;

    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
 
    void Start()
    {   
        _fight = false;
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetComponent<Animation>().isRun);
        if (GetComponent<Animation>().isRun)
        {
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
               
            }
        }
    }
    void UpdateDestination()
    {
        
        if (_fight == false)
        {
            target = waypoints[waypointIndex].position;
            agent.SetDestination(target);
        }


    }
    void IterateWaypointIndex()
    {
            
            waypointIndex++;
            Debug.Log("New point" + waypointIndex);
            GetComponent<Animation>().IdleAnim();
            _fight = true;
            


        
        
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            SceneManager.LoadScene(0);
        }
    }

}

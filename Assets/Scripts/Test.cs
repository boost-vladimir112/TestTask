using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnBecameVisible()
    {
        GetComponent<PlayerController>()._fight = true;
        Debug.Log("Visible");
    }
    private void OnBecameInVisible()
    {
        GetComponent<PlayerController>()._fight = false;
        Debug.Log("INVisible");
    }
}

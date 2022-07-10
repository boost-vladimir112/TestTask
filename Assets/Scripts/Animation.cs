using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;
    private bool _isRun;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRun", true);
        _isRun = anim.GetBool("isRun");


    }
    public bool isRun
    {
        get { return _isRun; }
        set { _isRun = anim.GetBool("isRun"); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        
    }
}

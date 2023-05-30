using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Pumpkinhulk_Animations : MonoBehaviour
{
    
     Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StopRunningAnim()
    {
        anim.SetBool("IsRunning", false);
    }

    public void RunningAnim()
    {
        anim.SetBool("IsRunning", true);
    }
}

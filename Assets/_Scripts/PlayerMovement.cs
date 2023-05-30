using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public float RotateSpeedMovement = .075f;                 // good rotate speed
    float RotateVelocity;

    public PlayerAnimator playerAnimator;


    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        // when pressing right mouse button
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            


            //checking if the raycast shots hit something that uses the nav mesh system.
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit , Mathf.Infinity))
            {
                // have the player move to the raycast point 
                agent.SetDestination(hit.point);

               
               


                // rotation
                Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                    rotationToLookAt.eulerAngles.y, ref RotateVelocity,
                    RotateSpeedMovement * (Time.deltaTime * 5));

                transform.eulerAngles = new Vector3(0, rotationY, 0);
            }
        }


        
    }
}

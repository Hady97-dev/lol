using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVFX : MonoBehaviour
{
    private Transform player;
    public GameObject Ability1_Mesh;
    public float Ability1_Speed;
    public GameObject target;
    public Transform FirePoint;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void PlayerAbility1_VFX()
    {
       var instance =  (Instantiate(Ability1_Mesh, player.position, Quaternion.identity));  // we used var insance   as you can not add effects to a prefab 
        instance.GetComponent<Rigidbody>().AddForce((target.transform.position - player.transform.position).normalized
            * Ability1_Speed, ForceMode.Impulse);      // very important line 
        Destroy (instance,3f);

        print("pppppp");

    }
}

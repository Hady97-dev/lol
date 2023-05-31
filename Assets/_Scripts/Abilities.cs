using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    [Header ("Ability1")]
    public Image ability1_icon_B;    
    public float CoolDown1 = 5f;
    bool IsCoolDown1 = false;

    [Header("Ability2")]
    public Image ability2_icon_B;
    public float CoolDown2 = 5f;
    bool IsCoolDown2 = false;

    // Start is called before the first frame update
    void Start()
    {
        ability1_icon_B.fillAmount = 0;
        ability1_icon_B.gameObject.SetActive(true);
        ability2_icon_B.fillAmount = 0;
        ability2_icon_B.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCoolDown1 == true)
        {
            Ability1();
        }
        if (IsCoolDown2 == true)
        {
            Ability2();
        }
    }

     public void Ability1()
     {
        if( IsCoolDown1 == false)
        {
            IsCoolDown1 = true;
            ability1_icon_B.fillAmount = 1;  
        }

        if(IsCoolDown1)
        {
            ability1_icon_B.fillAmount -= (1 / CoolDown1) * Time.deltaTime;

            if (ability1_icon_B.fillAmount <= 0)
            {
                IsCoolDown1 = false;
            }
        }   
     }
    public void Ability2()
    {
        if (IsCoolDown2 == false)
        {
            IsCoolDown2 = true;
            ability2_icon_B.fillAmount = 1;
        }

        if (IsCoolDown2)
        {
            ability2_icon_B.fillAmount -= (1 / CoolDown1) * Time.deltaTime;

            if (ability2_icon_B.fillAmount <= 0)
            {
                IsCoolDown2 = false;
            }
        }
    }


}




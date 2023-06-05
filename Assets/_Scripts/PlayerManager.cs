using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    // public GameObject Hulk;
    // public GameObject Maria;
    public int PlayerNumber;
    private int NextSceneToLoad;
    
    
    // Start is called before the first frame update
    void Start()
    {
       // DontDestroyOnLoad(this.gameObject);
        
        NextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerNumber = PlayerPrefs.GetInt("PlayerNum");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScenesButton()
    {
        SceneManager.LoadScene(NextSceneToLoad);
    }
    public void ChoosingHulk()
    {
        //when PlayerNum is 1 we instantiate hulk...etc
        PlayerPrefs.SetInt("PlayerNum", 1);     
       
         
    }
    public void ChoosingMaria()
    {
        
        PlayerPrefs.SetInt("PlayerNum", 2);
        
    }


}

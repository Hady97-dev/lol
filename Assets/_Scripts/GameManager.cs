using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Hulk;
    public GameObject Maria;
    int activeScene;
    private int NextSceneToLoad;
    public PlayerManager playerManager;


    // Start is called before the first frame update
   
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        activeScene = SceneManager.GetActiveScene().buildIndex;
        NextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

        InstantiateHulk();
        InstantiateMaria();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScenesButton()
    {
        SceneManager.LoadScene(NextSceneToLoad);
    }
    public void InstantiateHulk()
    {
       if (PlayerPrefs.GetInt("PlayerNum") == 1)
        {
            Instantiate(Hulk, new Vector3(-136, 0, -67), Quaternion.identity);
            print("hulk is here");
       }
        
         
    }
    public void InstantiateMaria()
    {

        if (PlayerPrefs.GetInt("PlayerNum") == 2)
        {
            Instantiate(Maria, new Vector3(-136, 0, -68), Quaternion.identity);
            print("hulk is here");
        }
    }


}

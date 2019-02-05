using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiateMenu : MonoBehaviour {

    public GameObject gameName;
    public GameObject menuAnimation;
    public GameObject menu;
    // Use this for initialization
    void Start ()
    {
        if (!GameManager.GameHasOpened)
        {
            gameName.SetActive(true);
            Invoke("StartMenuAnimation", 3.8f);
            Invoke("EnableMenu", 5f);
            GameManager.GameHasOpened = true;
        }
        else
        {
            menu.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartMenuAnimation()
    {
        menuAnimation.SetActive(true);
        gameName.SetActive(false);
    }
    public void EnableMenu()
    {
        menu.SetActive(true);
        menuAnimation.SetActive(false);
    }
}

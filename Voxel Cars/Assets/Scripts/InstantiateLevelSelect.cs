using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateLevelSelect : MonoBehaviour {

    public Button level;
	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < GameManager.levelAvailable; i++)
        {
            level = GameObject.Find("Level " + (i+1)).GetComponent<Button>();
            level.interactable = true;
        }
	}
}

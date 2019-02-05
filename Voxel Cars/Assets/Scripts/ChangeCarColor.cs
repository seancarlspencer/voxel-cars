using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeCarColor : MonoBehaviour {

	public void ChangeColor(string ID)
    {
        Debug.Log(ID);
        if (ID=="Button 1")
        {
            GameManager.carID = 1;
        }
        else if (ID == "Button 2")
        {
            GameManager.carID = 2;
        }
        else if (ID == "Button 3")
        {
            GameManager.carID = 3;
        }
        Debug.Log(GameManager.carID);
        SceneManager.LoadScene(0);
        Debug.Log(GameManager.carID);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelSelect : MonoBehaviour {

    public void GoToLevelSelection()
    {
        SceneManager.LoadScene("Level Selection");
    }
}

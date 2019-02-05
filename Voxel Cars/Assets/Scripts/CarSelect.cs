using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelect : MonoBehaviour {

	public void GoToCarSelection()
    {
        SceneManager.LoadScene("Car Select");
    }
}

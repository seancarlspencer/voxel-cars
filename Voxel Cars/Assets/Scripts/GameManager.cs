using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool GameHasEnded = false;
    public static bool GameHasOpened = false;
    public float restartDelay = 2f;
    public static int carID = 1;
    public static int levelAvailable = 0;
    public GameObject completeLevelUI;
    public PlayerCollision collision;

    void Start()
    {
        if (collision == null)
        {
            collision = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollision>();
        }
    }
    void FixedUpdate()
    {
        if (collision == null)
        {
            collision = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollision>();
        }
    }

    public void EndGame ()
    {
        GameHasEnded = true;
        FindObjectOfType<Score>().EndGame();
        Invoke("GoBackToMainMenu", restartDelay);
        // Restart();
    }
    public void WinGame()
    {
        GameHasEnded = true;
        FindObjectOfType<Score>().WinGame();
        completeLevelUI.SetActive(true);
    }
    void Restart()
    {
        GameHasEnded = false;
        completeLevelUI.SetActive(false);
        collision.hasCollided = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void GoBackToMainMenu()
    {
        GameHasEnded = false;
        completeLevelUI.SetActive(false);
        collision.hasCollided = false;
        SceneManager.LoadScene("Menu");
    }
}

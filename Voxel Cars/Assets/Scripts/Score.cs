using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public Transform player;
    public PlayerMovement movement;
    public Text score;
    public Text winningScore;
    public GameManager manager;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        if (movement == null)
        {
            movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        }
    }
    // Update is called once per frame
    void Update ()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        if (movement == null)
        {
            movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        }
        // if (movement.enabled)
        if (manager.GameHasEnded == false)
        {
            int updatedScore = (int)player.position.z + 45;
            score.text = "Score: " + updatedScore.ToString();
            // Can also use ToString("0") in order to make it round
            // it to 0 decimal places.
        }
	}
    public void EndGame()
    {
        int updatedScore = (int)player.position.z + 45;
        score.text = "GAME OVER!\nFinal Score: " + updatedScore.ToString();
    }
    public void WinGame()
    {

        int updatedScore = (int)player.position.z + 45;
        winningScore.text =  SceneManager.GetActiveScene().name +
            " Complete.\nFinal Score: " + updatedScore.ToString();
    }
}

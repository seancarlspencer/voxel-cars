using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiateScript : MonoBehaviour
{
    public GameManager manager;
    public GameObject test;
    // GameObject is prefab.
    public float gridX = 0f;
    public float gridY = 0f;
    public float gridZ = 0f;

    void Start()
    {
        if (GameManager.carID == 1)
        {
            test = Resources.Load("PlayerPrefabs/Player") as GameObject;
            Instantiate(test.transform, new Vector3(gridX, gridY, gridZ), Quaternion.identity);
        }
        else if (GameManager.carID == 2)
        {
            test = Resources.Load("PlayerPrefabs/Player 1") as GameObject;
            Instantiate(test.transform, new Vector3(gridX, gridY, gridZ), Quaternion.identity);
        }
        else if (GameManager.carID == 3)
        {
            test = Resources.Load("PlayerPrefabs/Player 2") as GameObject;
            Instantiate(test.transform, new Vector3(gridX, gridY, gridZ), Quaternion.identity);
        }
        if (GameManager.levelAvailable<SceneManager.GetActiveScene().buildIndex)
        {
            GameManager.levelAvailable = SceneManager.GetActiveScene().buildIndex;
        }
        PlayerMovement playertest = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playertest.forwardForce = SceneManager.GetActiveScene().buildIndex * 500 + 4000;
    }
}

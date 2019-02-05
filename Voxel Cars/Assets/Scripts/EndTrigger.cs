using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager manager;
    public PlayerCollision collidePrevention;
    void Start()
    {
        if (collidePrevention == null)
        {
            collidePrevention = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollision>();
        }
    }

    void FixedUpdate()
    {
        if (collidePrevention == null)
        {
            collidePrevention = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollision>();
        }
    }

    private void OnTriggerEnter()
    {
        if (collidePrevention.hasCollided)
        {

        }
        else
        {
            manager.WinGame();
        }
    }
}

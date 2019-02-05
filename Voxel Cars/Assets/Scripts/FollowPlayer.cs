using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        else
        {
            transform.position = player.position + offset;
        }
	}
}

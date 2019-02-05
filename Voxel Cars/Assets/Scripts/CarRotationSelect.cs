using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotationSelect : MonoBehaviour {

    public Transform player;
	// Update is called once per frame
	void FixedUpdate ()
    {
            player.eulerAngles = new Vector3
                    (0, player.eulerAngles.y + 1, 0);
    }
}

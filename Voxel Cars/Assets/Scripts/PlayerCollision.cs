
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public bool hasCollided = false;
    // public GameManager manager; We do not use this because we
    // cannot instantiate with a GameManager object

    void Start()
    {
        if (movement == null)
        {
            movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        }
    }

    void FixedUpdate()
    {
        if (movement == null)
        {
            movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            if (!hasCollided)
            {
                Debug.Log("You hit an obstacle");
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
                hasCollided = true;
            }
        }
    }
}

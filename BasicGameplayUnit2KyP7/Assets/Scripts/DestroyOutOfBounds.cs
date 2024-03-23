using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    float topBoundary = 50.0f;
    float lowBoundary = -30.0f;
    float sideBoundaries = 40.0f;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //destroys gameObjects that are out of the player view
        if (transform.position.z > topBoundary)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBoundaries)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBoundaries)
        {
            gameManager.AddLives(-1);
            Destroy (gameObject);
        }
        else if (transform.position.z < lowBoundary)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}

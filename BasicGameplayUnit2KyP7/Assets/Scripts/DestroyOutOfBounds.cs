using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    float topBoundary = 50.0f;
    float lowBoundary = -30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroys gameObjects that are out of the player view
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBoundary)
        {
            //when animals go past player, game over.
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

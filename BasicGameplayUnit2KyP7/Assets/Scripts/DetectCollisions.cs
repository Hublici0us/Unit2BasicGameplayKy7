using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
    public GameObject food;
    public int lives;

    SpawnManager spawn;
    PlayerController pControl;
    GameManager gManager;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GetComponent<SpawnManager>();
        pControl = GetComponent<PlayerController>();
        gManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    //when animals and the food collide, destroy both.
    {

        if (other.CompareTag("Enemies"))
        {
            gManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

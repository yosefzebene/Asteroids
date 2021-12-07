using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ship;  
    public int respawns;   // Ship respawns

    private bool playerSpawned;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ship, gameObject.transform.position, Quaternion.identity);
        playerSpawned = true;
    }

    private void Update()
    {
        if (!playerSpawned && Input.GetMouseButtonDown(0))
        {
            Vector2 playerSpawnPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Instantiate(ship, playerSpawnPoint, Quaternion.identity);
            playerSpawned = true;
        }
    }

    public void SpawnNewShip()
    {
        if (respawns > 0)
        {
            playerSpawned = false;
        }
        else
        {
            //replace with a Game over screen later
            
        }
    }
}

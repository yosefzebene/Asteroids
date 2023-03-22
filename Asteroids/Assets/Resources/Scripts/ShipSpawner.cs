using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ship;  
    public int respawns;   // Ship respawns

    //UI
    public GameObject DeathScreen;
    public GameObject GameOverScreen;

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
            DeathScreen.SetActive(false);
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

            DeathScreen.SetActive(true);
        }
        else
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void ResetRespawns()
    {
        respawns = 3;
        playerSpawned = false;
    }
}

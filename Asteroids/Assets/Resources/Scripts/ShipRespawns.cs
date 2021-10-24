using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRespawns : MonoBehaviour
{
    private ShipSpawner shipSpawner;

    private void Start()
    {
        shipSpawner = GameObject.Find("Ship Spawner").GetComponent<ShipSpawner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Astroid"))
        {
            shipSpawner.respawns--;

            Destroy(gameObject);

            shipSpawner.SpawnNewShip();
        }
    }
}

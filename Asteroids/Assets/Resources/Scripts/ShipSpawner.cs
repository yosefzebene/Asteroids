using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ship;
    
    public int respawns;   // Ship respawns

    // Start is called before the first frame update
    void Start()
    {
        respawns = 5;

        Instantiate(ship, gameObject.transform.position, Quaternion.identity);
    }

    public void SpawnNewShip()
    {
        if (respawns > 0)
            Instantiate(ship, gameObject.transform.position, Quaternion.identity);
    }
}

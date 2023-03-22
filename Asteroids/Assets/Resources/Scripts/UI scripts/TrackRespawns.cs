using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackRespawns : MonoBehaviour
{
    public GameObject life_1;
    public GameObject life_2;
    public GameObject life_3;
    private GameObject shipRespawner;
    private ShipSpawner sHealth;

    private void Start()
    {
        shipRespawner = GameObject.Find("Ship Spawner");

        if (shipRespawner != null)
            sHealth = shipRespawner.GetComponent<ShipSpawner>();
    }//Start

    // Update is called once per frame
    private void Update()
    {
        if (sHealth != null)
        {
            switch (sHealth.respawns)
            {
                case 2:
                    life_3.SetActive(false); break;
                case 1:
                    life_2.SetActive(false); break;
                case 0:
                    life_1.SetActive(false); break;
                default:
                    life_1.SetActive(true);
                    life_2.SetActive(true);
                    life_3.SetActive(true);
                    break;
            }
        }
    }//update
}

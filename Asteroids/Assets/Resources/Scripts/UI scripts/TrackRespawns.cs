using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackRespawns : MonoBehaviour
{
    private Text respawns;
    private GameObject shipRespawner;
    private ShipSpawner sHealth;

    private void Start()
    {
        respawns = GetComponent<Text>();

        shipRespawner = GameObject.Find("Ship Spawner");

        if (shipRespawner != null)
            sHealth = shipRespawner.GetComponent<ShipSpawner>();
    }//Start

    // Update is called once per frame
    private void Update()
    {
        if (sHealth != null)
            respawns.text = "Respawns: " + sHealth.respawns;
    }//update
}

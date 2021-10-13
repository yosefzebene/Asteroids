using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackHealth : MonoBehaviour
{
    private Text health;
    private GameObject ship;
    private ShipHealth sHealth;

    private void Start()
    {
        health = GetComponent<Text>();

        ship = GameObject.Find("Ship");

        sHealth = ship.GetComponent<ShipHealth>();
    }//Start

    // Update is called once per frame
    private void Update()
    {
        health.text = "Health: " + sHealth.GetHealth();
    }//update
}

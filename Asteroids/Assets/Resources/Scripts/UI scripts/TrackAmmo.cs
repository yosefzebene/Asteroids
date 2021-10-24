using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackAmmo : MonoBehaviour
{
    private Text ammo;
    private GameObject ship;
    private ShipGunController gunController;
    
    // Start is called before the first frame update
    private void Start()
    {
        ammo = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        ship = GameObject.Find("Ship(Clone)");

        if (ship != null)
            gunController = ship.GetComponent<ShipGunController>();

        if (gunController != null)
            ammo.text = gunController.GetAmmo().ToString();
    }
}

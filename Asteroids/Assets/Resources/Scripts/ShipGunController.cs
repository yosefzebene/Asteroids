using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGunController : MonoBehaviour
{
    public Transform Gun1, Gun2;
    private Transform G;
    bool alternate = false;

    public GameObject bulletPrefab;          // Bullet prefab
    private float bulletForce = 50f;     // The speed of the bullet
    private int ammo = 50;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {
                Shoot();
            }
        }
    }//update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AmmoBox"))
        {
            int ammoCapacity = collision.gameObject.GetComponent<AmmoBoxCapacity>().ammoCapacity;

            ammo += ammoCapacity;
        }
    }

    private void Shoot()
    {
        // Alternate guns
        if (!alternate) {
            G = Gun1;
            alternate = true;
        }
        else {
            G = Gun2;
            alternate = false;
        }//if-else

        // Decrease ammo
        ammo -= 1;

        GameObject bullet = Instantiate(bulletPrefab, G.position, G.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(G.up * bulletForce, ForceMode2D.Impulse);
    }//shoot

    public int GetAmmo()
    {
        return ammo;
    }
}

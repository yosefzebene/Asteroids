using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGunController : MonoBehaviour
{
    public Transform Gun1, Gun2;
    private Transform G;
    bool alternate = false;

    public GameObject bulletPrefab;          // Bullet prefab
    public float bulletForce = 20f;     // The speed of the bullet

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }//if
    }//update

    void Shoot()
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

        GameObject bullet = Instantiate(bulletPrefab, G.position, G.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(G.up * bulletForce, ForceMode2D.Impulse);
    }//shoot
}

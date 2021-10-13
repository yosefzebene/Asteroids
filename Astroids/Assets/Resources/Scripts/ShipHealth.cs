using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    private int health = 100;   // Ship health

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            Destroy(gameObject);
        }//if
    }//update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Astroid"))
        {
            health -= 10;
        }//if
    }

    public int GetHealth()
    {
        return health;
    }//GetHealth
}

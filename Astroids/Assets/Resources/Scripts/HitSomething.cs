using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSomething : MonoBehaviour
{
    public int Damage;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Astroid")) {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    public GameObject hitEffect;

    private GameObject b;

    // Start is called before the first frame update
    void Start()
    {
        var bullet = Resources.Load<GameObject>("Prefab/bullet");
        b = bullet;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            //Count point
            if (gameObject.name == "Big astroid(Clone)")
            {
                TrackPoints.points += 20;
            } 
            else if (gameObject.name == "medium astroid 2(Clone)" || gameObject.name == "medium astroid 2(Clone)")
            {
                TrackPoints.points += 15;
            }
            else
            {
                TrackPoints.points += 5;
            }

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Bullet")){

            Instantiate(hitEffect, transform.position, Quaternion.identity);
            Health -= b.GetComponent<HitSomething>().Damage;
        }
    }
}

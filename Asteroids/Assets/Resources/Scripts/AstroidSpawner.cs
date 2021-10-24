using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    public Transform s1, s2, s3, s4;   // Spawner positions
    public GameObject bigastroid, mediumAstroid1, mediumAstroid2, smallAstroid;   // Astroid prefab
    public GameObject ammoBox; // Ammo box prefab
    public float astroidSpeed = 20f;   // The force to be aplied to each astorid
    public float waitTime = 2.0f; // Wait time between astroid spawning;

    private Transform activeSpawner;   // Active spawner position
    private GameObject randAstroid;   // Random astroid size to spawn
    private int random;   // Random number
    private float timer = 0.0f; // Timer
    private float lastTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lastTime + waitTime)
        {
            SpawnAstroid();

            lastTime = timer;
        }
    }//update

    private void SpawnAstroid()
    {
        Vector3 randomRotation = transform.rotation.eulerAngles;

        random = Random.Range(1, 5);

        switch (random)
        {
            case 1:
                // Generate a random number for randomizing the rotation of the spawner
                randomRotation.z = Random.Range(-130f, -49f);
                
                s1.transform.rotation = Quaternion.Euler(randomRotation);

                activeSpawner = s1;

                PickAstroid(); 
                break; //case 1
            case 2:
                randomRotation.z = Random.Range(-40, 41);
                s2.transform.rotation = Quaternion.Euler(randomRotation);

                activeSpawner = s2;

                PickAstroid();
                break; //case2
            case 3:
                randomRotation.z = Random.Range(50, 131);
                s3.transform.rotation = Quaternion.Euler(randomRotation);

                activeSpawner = s3;

                PickAstroid();
                break;//case3
            case 4:
                randomRotation.z = Random.Range(-220, -149);
                s4.transform.rotation = Quaternion.Euler(randomRotation);

                activeSpawner = s4;

                PickAstroid();
                break;//case4
        }//switch

        GameObject astroid = Instantiate(randAstroid, activeSpawner.position, activeSpawner.rotation);

        Rigidbody2D rb = astroid.GetComponent<Rigidbody2D>();
        rb.AddForce(activeSpawner.up * astroidSpeed, ForceMode2D.Impulse);
    }//SpawnAstroid

    private void PickAstroid()
    {
        random = Random.Range(1, 6); // Random number from 1 - 4

        switch (random)
        {
            case 1:
                randAstroid = smallAstroid;
                break;//case1
            case 2:
                randAstroid = mediumAstroid1;
                break;//case2
            case 3:
                randAstroid = mediumAstroid2;
                break;//case3
            case 4:
                randAstroid = bigastroid;
                break;//case4
            case 5:
                randAstroid = ammoBox;
                break;//case5
        }//switch
    }//PickAstroid
}
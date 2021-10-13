using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    public Transform s1, s2, s3, s4;   // Spawner positions
    public GameObject bigastroid, mediumAstroid1, mediumAstroid2, smallAstroid;   // Astroid prefab
    public float astroidSpeed = 20f;   // The force to be aplied to each astorid

    private Transform activeSpawner;   // Active spawner position
    private GameObject randAstroid;   // Random astroid size to spawn
    private int random;   // Random number

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnAstroid();
        }
    }//update

    private void SpawnAstroid()
    {
        int randomRotation;

        random = Random.Range(1, 5);

        switch (random)
        {
            case 1:
                // Generate a random number for randomizing the rotation of the spawner
                randomRotation = Random.Range(-130, -49);
                s1.transform.Rotate(0, 0, randomRotation, Space.World);

                activeSpawner = s1;

                PickAstroid();
                break; //case 1
            case 2:
                randomRotation = Random.Range(-40, 41);
                s2.transform.Rotate(0, 0, randomRotation, Space.World);

                activeSpawner = s2;

                PickAstroid();
                break; //case2
            case 3:
                randomRotation = Random.Range(50, 131);
                s3.transform.Rotate(0, 0, randomRotation, Space.World);

                activeSpawner = s3;

                PickAstroid();
                break;//case3
            case 4:
                randomRotation = Random.Range(-220, -149);
                s4.transform.Rotate(0, 0, randomRotation, Space.World);

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
        random = Random.Range(1, 5); // Random number from 1 - 4

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
        }//switch
    }//PickAstroid
}
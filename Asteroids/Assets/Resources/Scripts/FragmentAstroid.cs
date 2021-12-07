using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentAstroid : MonoBehaviour
{
    public GameObject smallAstroid;  // Small astroid to fragment bigger astroids
    public float astroidSpeed = 20f;

    public static bool isQuitting; // Status of the application quiting

    private Transform currentAstorid;

    private void Start()
    {
        currentAstorid = GetComponent<Transform>();
        isQuitting = false;
    }

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    private void OnDestroy()
    {
        if (!isQuitting)
        {
            Vector3 parentAstroid;

            // First fragment
            parentAstroid = currentAstorid.rotation.eulerAngles;

            //randomAngle = Random.Range(-20f, 20f);
            parentAstroid.z -= 20f;

            GameObject fragment1 = Instantiate(smallAstroid, currentAstorid.position, Quaternion.Euler(parentAstroid));

            Rigidbody2D rb1 = fragment1.GetComponent<Rigidbody2D>();
            Transform tr1 = fragment1.GetComponent<Transform>();
            rb1.AddForce(tr1.up * astroidSpeed, ForceMode2D.Impulse);

            // Second fragment
            parentAstroid = currentAstorid.rotation.eulerAngles;

            //randomAngle = Random.Range(-20f, 10f);
            parentAstroid.z += 20f;

            GameObject fragment2 = Instantiate(smallAstroid, currentAstorid.position, Quaternion.Euler(parentAstroid));

            Rigidbody2D rb2 = fragment2.GetComponent<Rigidbody2D>();
            Transform tr2 = fragment2.GetComponent<Transform>();
            rb2.AddForce(tr2.up * astroidSpeed, ForceMode2D.Impulse);

        }
    } 
}

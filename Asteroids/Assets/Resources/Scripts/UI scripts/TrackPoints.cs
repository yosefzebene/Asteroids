using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackPoints : MonoBehaviour
{
    private Text pointsUI;

    public static int points { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        pointsUI = GetComponent<Text>();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointsUI.text = points.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{

    public float xPos = 0f;
    public float yPos = 0f;
    public float xSpeed = 1.0f;
    public float ySpeed = 1.0f;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPos, yPos, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPos += xSpeed * Time.deltaTime;
        //xPos = xPos + xSpeed x Time.deltaTime; does the same
        yPos += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPos, yPos, 0f);

    }
}

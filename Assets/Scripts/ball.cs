using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
   
    public float xPos = 2f;
    public float yPos = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPos, yPos, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPos = xPos + 0.005f;
        transform.position = new Vector3(xPos, yPos, 0f);

    }
}

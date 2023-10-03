using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPos = 0f;
    public float yPos = 0f;
    public float xSpeed = 1.0f;
    public float ySpeed = 1.0f;


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("auw my hat or my feet");
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("verticalWall"))
        {
            Debug.Log("auw! my but or my crotch");
            xSpeed = xSpeed * -1f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed = 3.0f;
    public string paddle;
    public float maxPlace = 7f;



    void PaddleControl(KeyCode left, KeyCode right)
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -maxPlace)
        {

            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < maxPlace)
        {

            transform.Translate(speed * Time.deltaTime * Vector3.right);
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        //getkey works when you keep pressing it getkeydown only workse once a tap
        if (paddle == "paddle")
        {

            PaddleControl(KeyCode.A, KeyCode.D);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
}

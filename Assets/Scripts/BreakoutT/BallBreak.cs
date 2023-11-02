using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBreak : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public float speed = 300;

    private Vector2 velocity;

    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
        ResetBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone"))
        {
            FindObjectOfType<GameManager>().LosseHealth();

        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            
            rigidbody2D.velocity = Vector2.zero;
            velocity.x = Random.Range(1f, 1.5f);
            velocity.y = Random.Range(1f, 1.5f);
            rigidbody2D.AddForce(velocity * speed);
            Debug.Log("UWU");
        }
    }
   
    public void ResetBall()
    {
        transform.position = startPosition;
        rigidbody2D.velocity =Vector2.zero;
        
        velocity.x = Random.Range(-2f, 2f);
        velocity.y = Random.Range(1f, 2f);
        rigidbody2D.AddForce(velocity * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
  public float speed = 10f;
  public float maxSpeed = 20f;
  Rigidbody2D rb;

  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();

    Vector2 direction = new Vector2(Random.Range(-1.0f, 0.0f), Random.Range(-1.0f, 0.0f));
    Move(direction);
  }

  void FixedUpdate()
  {
    //ensure that the speed of the object never gets totally out of hand
    float speed = rb.velocity.magnitude;
    rb.velocity = rb.velocity / speed * Mathf.Min(speed, maxSpeed);

    //if it ever stops moving left to right, give it some left acceleration
    if (rb.velocity.x == 0.0)
    {
      rb.AddForce(transform.right * Random.Range(-2.0f, 2.0f));
    }

    if (rb.velocity.y == 0.0)
    {
      rb.AddForce(transform.up * Random.Range(-2.0f, 2.0f));
    }

  }

  void Move(Vector2 direction)
  {
    rb.velocity = direction * speed;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public float paddleSpeed = 10f;
  public KeyCode upKey;
  public KeyCode downKey;

  void Update()
  {
    //if pressing up go up
    if (Input.GetKey(upKey))
    {
      MoveUp();
    }
    else if (Input.GetKey(downKey))
    {
      MoveDown();
    }
    else
    {
      Move(Vector2.zero);
    }
  }

  void MoveUp()
  {
    Move(Vector2.up);
  }

  void MoveDown()
  {
    Move(Vector2.down);
  }

  void Move(Vector2 direction)
  {
    transform.Translate(direction * paddleSpeed * Time.deltaTime);
  }

}

using UnityEngine;
using System.Collections;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class BulletMove : MonoBehaviour
{

  public Vector2 speed = new Vector2(10, 10);
  public Vector2 direction = new Vector2(-1, 0);
  public Rigidbody2D _Rigid;
  private Vector2 movement;

  void start() 
  {
      _Rigid = GetComponent<Rigidbody2D>();
  }
  void Update()
  {
    // 2 - Movement
    movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y);
  }

  void FixedUpdate()
  {
    // Apply movement to the rigidbody
      transform.Rotate(0, 0, 6);
      _Rigid.velocity = movement;
  }
}
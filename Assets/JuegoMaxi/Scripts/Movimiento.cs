using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int speed = 5;
    Rigidbody2D rigidbody2d;
    Animator animator;
    float verticalAxis;
    float horizontalAxis;
    SpriteRenderer sprite;

    public Vector2 movement;
    // Start is called before the first frame update

    void Start()
    {
      rigidbody2d = GetComponent<Rigidbody2D>();
      animator = GetComponent<Animator>();
      sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         movement = new Vector2(horizontalAxis, verticalAxis);
        rigidbody2d.MovePosition(rigidbody2d.position + (speed * Time.deltaTime * movement.normalized));
    }

    private void Update()
    {
        Run();
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
        //Debug.Log("Eje X: " + horizontalAxis + ", Eje Y: " + verticalAxis);
        float run = horizontalAxis + verticalAxis;
        animator.SetFloat("Run",math.abs(run));

        if (sprite.flipX == false && movement.x < 0)
        {
            sprite.flipX = true;
        }
        else if (sprite.flipX == true && movement.x > 0)
        {
            sprite.flipX = false;
        }
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;

        }
        else
        {
            speed = 5;
            
        }
    }

        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int speed = 5;
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update

    void Start()
    {
      rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2d.MovePosition(rigidbody2d.position + (Vector2.up * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2d.MovePosition(rigidbody2d.position + (Vector2.left * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2d.MovePosition(rigidbody2d.position + (Vector2.right * speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2d.MovePosition(rigidbody2d.position + (Vector2.down * speed * Time.deltaTime));
        }







    }
}

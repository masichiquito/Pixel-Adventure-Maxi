using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRock : MonoBehaviour 
{
    public int damageQuantity = 20;
    private Rigidbody2D rigidbody2d;
    private Vector2 direccion;

    public float speed = 3;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        direccion = Vector2.right;
    
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody2d.MovePosition(rigidbody2d.position + (direccion * speed * Time.deltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {// si (colisionador2D que entró esta vacio?)
        if (collision2D != null)
        {
            direccion = direccion * -1;

            if (collision2D.gameObject.tag == "Player")
            {
               
                Debug.Log("Ouch, *-10 de vida*");
                collision2D.collider.GetComponent<Health>().Damage(damageQuantity); 
            }
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null)
        {
            
        }
    }
}

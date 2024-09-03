using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int healQuantity = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision1)
    {
        if (collision1 != null)
        {
            Debug.Log("Ganaste");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D != null && collider2D.gameObject.tag == "Player")
        {
            Debug.Log("Algo Entro");
            collider2D.GetComponent<Health>().Heal(healQuantity);
            Destroy(this.gameObject);
            
        }
    }


    // Update is called once per frameD
    void Update()
    {
        
    }
}

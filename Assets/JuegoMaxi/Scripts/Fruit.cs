using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
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

    private void OnTriggerEnter2D(Collider2D collision2)
    {
        if (collision2 != null)
        {
            Debug.Log("Algo Entro");
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

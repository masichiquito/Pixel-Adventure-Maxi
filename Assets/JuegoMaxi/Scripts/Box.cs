using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {// si (colisionador2D que entr� esta vacio?)
        if (collision != null)
        {
            Debug.Log("algo Colision�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public int damageQuantity = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null)
        {
           
            Debug.Log("Ouch, *-10 de vida*");
            collider.GetComponent<Health>().Damage(damageQuantity);
            
        }
    }
}

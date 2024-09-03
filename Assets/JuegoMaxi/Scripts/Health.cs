using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
  
{
    public Animator animator;
    public int health = 100;
    public CapsuleCollider2D capsuleCollider2D;
    public Movimiento movimiento;
    public UI ui;
    
    // Start is called before the first frame update
    void Start()
    {
        ui.SetSliderValuer(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damageQuantity)
    {
        animator.SetTrigger("Damage");
        health = health - damageQuantity;
        if (health <= 0)
        {
            health = 0;
            animator.SetTrigger("Die");
            capsuleCollider2D.enabled = false;
            movimiento.enabled = false;
            this.enabled = false;
            
        }
        ui.SetSliderValuer(health);


    }
        
    public void Heal(int healQuantity)
    {
        health = health + healQuantity;
        //animator.SetTrigger("Heal");
        if (health > 100)
        {
            health = 100;
        }
        ui.SetSliderValuer(health);
    }

    public void Die()
    {
      this.gameObject.SetActive(false);
      ui.GameOver();
    }

    
}

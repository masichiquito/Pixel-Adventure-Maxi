
using UnityEngine;

public class HeadRock : MonoBehaviour 
{
    private Rigidbody2D rigidbody2d;
    private Vector2 direction; 

    [Header("Enemy Configuration")]

    public int damageQuantity = 20;
    public bool isRightToLeft = true;
    public float speed = 3;

    [Header("Boss Enemy Configuration")]

    public bool isBoss = false;
    private float time;
    private float tempo;
    private float gameTime;
    private float additionalTime;
    public int health = 3;
    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        EnemyConfiguration();
    }
    private void EnemyConfiguration()
    {
        if (isRightToLeft)
        {
            direction = Vector2.right;
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezeRotation ^ RigidbodyConstraints2D.FreezePositionY;
        }
        else 
        {
            direction = Vector2.up;
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezeRotation ^ RigidbodyConstraints2D.FreezePositionX;
        }

    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isBoss)
            BossMovement();

        
        rigidbody2d.MovePosition(rigidbody2d.position + (direction * speed * Time.deltaTime));
    }

    private void BossMovement()
    {
        gameTime = Time.time;
        if (gameTime > additionalTime)
        {
            float randomTime = Random.Range(1, 4f);
            additionalTime = gameTime + randomTime;

            isRightToLeft = !isRightToLeft;
            EnemyConfiguration();

            bool isLessThan50Percent = Random.value < 0.5f;
            direction *= isLessThan50Percent ? -1 : 1;
        }
    }                                   

    private void OnCollisionEnter2D(Collision2D collision2D)
    {// si (colisionador2D que entró esta vacio?)
        if (collision2D != null)
        {
            direction = direction * -1;

            if (collision2D.gameObject.tag == "Player")
            {
               
                Debug.Log("Ouch, *-10 de vida*");
                collision2D.collider.GetComponent<Health>().Damage(damageQuantity); 
            }
            

        }
    }

    

    public void Damage()
    {
        health -= 1;
        animator.SetTrigger("Hit");
        if (health <= 0)
        {
            health = 0;
            this.enabled = false;
            Invoke(nameof(Destroy), 1f);
        }
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}

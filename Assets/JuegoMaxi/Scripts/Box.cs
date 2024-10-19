using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject[] breakBox;
    private GameObject partBreakBox;
    public float breakSpeed = 1f;
    public bool isMetalBox = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision != null && collision.gameObject.CompareTag("Player"))
        if (collision != null && collision.gameObject.CompareTag("EnemyBoss"))
        {
            DestroyBoxParts();

            if (isMetalBox)
                collision.collider.GetComponent<HeadRock>().Damage();
        }
    }

    private void DestroyBoxParts()
    {
        for (int i = 0; i < breakBox.Length; i++)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            partBreakBox = Instantiate(breakBox[i], transform.position, rotation);
            partBreakBox.GetComponent<Rigidbody2D>().AddForce((Random.insideUnitCircle * breakSpeed), ForceMode2D.Impulse);
        }
        Destroy(this.gameObject);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision != null)
        {
            //Debug.Log("Algo esta en colisionando");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       
    }

}

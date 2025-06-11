using UnityEngine;

public class Powers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D != null && collider2D.gameObject.tag == "Player")
        {
            Debug.Log("I've got the power!!!");
            collider2D.GetComponent<Movimiento>().powerKick = true;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

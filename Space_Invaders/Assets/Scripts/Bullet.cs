using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string type;
    private Rigidbody2D rb;
    public int bullet_speed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update

    void Start()
    {
        Movement();
    }

    private void Movement()
    {
        rb.velocity = new Vector2(0, bullet_speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(type=="Player")
        {
            if(collision.gameObject.tag=="Enemy")
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
        else if(type == "Enemy")
        {
            if(collision.gameObject.tag=="Player")
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
        if(collision.gameObject.tag=="Block")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}

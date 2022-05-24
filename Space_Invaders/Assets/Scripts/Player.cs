using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public GameObject bullet;
    public bool shoot=true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position += Vector3.right;
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position += Vector3.left;
    }

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&shoot)
        {
            Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + 1), Quaternion.identity);
            StartCoroutine(Disable_Shoot(1));
        }
    }
    IEnumerator Disable_Shoot(float time)
    {
        shoot = false;
        yield return new WaitForSecondsRealtime(time);
        shoot = true;
    }
}

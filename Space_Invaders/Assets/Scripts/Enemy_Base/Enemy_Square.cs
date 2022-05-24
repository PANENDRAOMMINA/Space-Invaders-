using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Square : MonoBehaviour
{

   
    public GameObject[] enemies;
    public GameObject enemy_bullet;
    public static Enemy_Square instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        enemies=GameObject.FindGameObjectsWithTag("Enemy");
        
    }

    public void Start()
    {
        StartCoroutine(Let_Enemy_Shoot(2));
    }

    IEnumerator Let_Enemy_Shoot(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        int enemy_id = Random.Range(0,enemies.Length);
        if(enemies[enemy_id]!=null)
        {
            Vector2 enemy_shooter_position = new Vector2(enemies[enemy_id].transform.position.x, enemies[enemy_id].transform.position.y - 1);
            Instantiate(enemy_bullet, enemy_shooter_position, Quaternion.identity);
        }
        StartCoroutine(Let_Enemy_Shoot(2));
    }
    public void delete_array_element()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Square : MonoBehaviour
{
    public List<GameObject> _enemies = new List<GameObject>();
    public GameObject[] enemies;
    public GameObject enemy_bullet;

    private void Awake()
    {
        enemies=GameObject.FindGameObjectsWithTag("Enemy");
        foreach(var enemy in enemies)
        {
            _enemies.Add(enemy);
        }
    }

    public void Start()
    {
        StartCoroutine(Let_Enemy_Shoot(2));
    }
    IEnumerator Let_Enemy_Shoot(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        int enemy_id = Random.Range(0, 27);
        Vector2 enemy_shooter_position = new Vector2(_enemies[enemy_id].transform.position.x,_enemies[enemy_id].transform.position.y-1);
        Instantiate(enemy_bullet,enemy_shooter_position,Quaternion.identity);
        StartCoroutine(Let_Enemy_Shoot(2));
    }
}

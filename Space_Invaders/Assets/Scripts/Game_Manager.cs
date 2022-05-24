using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        if(Enemy_Square.instance.enemies.Length==0)
        {
            Debug.Log("You won");
            StartCoroutine(restart_level());
        }
    }
    public void Restart_level()
    {
        Debug.Log("You lose");
        StartCoroutine(restart_level());
    }
    IEnumerator restart_level()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    bool move_left=true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(move());
    }

    private void Update()
    {
        if (transform.position.x >= 9&&!move_left)
            move_left = true;
        if (transform.position.x <= -7&&move_left)
            move_left = false;
    }
    IEnumerator move()
    {
        yield return new WaitForSecondsRealtime(1f);
        if (move_left)
        {
            transform.Translate(Vector3.left);
        }
        else
        {
            transform.Translate(Vector3.right);
        }
      
        StartCoroutine(move());
    }
   
   
}

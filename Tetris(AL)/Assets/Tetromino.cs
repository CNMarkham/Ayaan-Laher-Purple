using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tetromino : MonoBehaviour
{
    private float previousTime;
    public float  fallTime = 0.8f;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        if (Time.time - previousTime > fallTime)
        {
            transform.position += Vector3.down;
            previousTime = Time.time;
        }

    }   
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tetromino : MonoBehaviour
{
    private float previousTime;
    public float fallTime = 0.8f;
    public static int width = 10;
    public static int height = 20;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;

            if (!ValidMove())
            {
                transform.position += Vector3.right;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;

            if (!ValidMove())
            {
                transform.position += Vector3.left;
            }
        }

        float tempTime = fallTime;
        if (Time.time - previousTime > tempTime)
        {
            transform.position += Vector3.down;

            if(!ValidMove())
            {
                transform.position += Vector3.up;
            }

            previousTime = Time.time;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;
        }
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
            if (x < 0 || y < 0 || x >= width || y >= height)
            {
                return false;
            }
        }
        return true;
    }
}
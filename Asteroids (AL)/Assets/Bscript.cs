using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bscript : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
    }
}

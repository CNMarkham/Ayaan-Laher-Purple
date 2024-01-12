using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bscript : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

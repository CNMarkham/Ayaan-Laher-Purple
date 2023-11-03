using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brickPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            Instantiate(brickPrefab, new Vector2(x * xSpace, 3), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

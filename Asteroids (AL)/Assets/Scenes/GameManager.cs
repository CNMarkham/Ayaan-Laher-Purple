using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new 
        Instanstiate(rockPrefab, Vector3.zero, Quaternion.identity);
    }
}
S
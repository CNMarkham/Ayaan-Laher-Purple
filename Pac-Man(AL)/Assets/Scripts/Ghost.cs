using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
    public GameObject body;
    public GameObject eyes;
    public GameObject blue;
    public GameObject white;
    public bool atHome;
    public float homeDirection;
    private bool frightened;
    private void Awake()
    {
      
    }
    protected override void ChildUpdate()
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();

        if (node != null)
        {

        }
    }

    private void LeaveHome()
    {

    }

    public void Frighten()
    {

    }

    private void Flash()
    {

    }

    private void Reset()
    {
         
    }
}


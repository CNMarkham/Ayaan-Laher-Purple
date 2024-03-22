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
    public float homeDuration;
    private bool frightened;
    private void Awake()
    {
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightened = false;
        Invoke("LeaveHome", homeDuration);
    }
    protected override void ChildUpdate()
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SetDirection(-direction);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();

        if (node != null)
        {
            int index = Random.Range(0, node.avaliableDirections.Count);

            index += 1;

            if(index == node.avaliableDirections.Count)
            {
                index = 0;
            }

            SetDirection(node.avaliableDirections[index]);
        }
    }

    private void LeaveHome()
    {
        transform.position = new Vector3(0, 2.5f, -1f);
        direction = new Vector2(-1, 0);
        atHome = false;
        body.SetActive(true);
        eyes.SetActive(true);
        white.SetActive(true);
        blue.SetActive(true);
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> avaliableDirections;
    private void CheckAvailableDirection(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1f, obstacleLayer);

        if (hit.collider == null)
        {
            avaliableDirections.Add(newDirection);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        avaliableDirections = new List<Vector2>();

        CheckAvailableDirection(Vector2.up);
        CheckAvailableDirection(Vector2.down);
        CheckAvailableDirection(Vector2.left);
        CheckAvailableDirection(Vector2.right);
    }

}

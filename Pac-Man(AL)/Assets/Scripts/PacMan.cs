using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : Movement
{
    private bool Occupied(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1.5f, obstacleLayer);
        return hit.collider != null;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : Movement
{
    void Update()
    { 
        if (nextDirection != Vector2.zero)
        {
            SetDirection(nextDirection);
        }

        ChildUpdate();
    }
}
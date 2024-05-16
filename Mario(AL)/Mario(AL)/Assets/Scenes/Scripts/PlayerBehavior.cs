using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteRenderer smallRenderer;
    public SpriteRenderer bigRenderer;
    private Animator smallAnimator;
    public bool big;

    // Start is called before the first frame update
    private void Start()
    {
        smallAnimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }

    public void Hit()
    {
        if (big)
        {
            Shrink();
        } else
        {
            Death();
        }
    }

    private void Shrink()
    {
        smallRenderer.enabled = true;
        bigRenderer.enabled = false;

        GetComponent<CapsuleCollider2D>().size = Vector2.one;
        GetComponent<CapsuleCollider2D>().offset = Vector2.zero;

        big = false;
        StartCoroutine("ChangeSize");
    }

    public void Grow()
    {
        if (big)
        {
            return;
        }

        smallRenderer.enabled = false;
        bigRenderer.enabled = true;

        GetComponent<CapsuleCollider2D>().size = new Vector2(1f, 2f);
        GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.5f);

        big = true;
        StartCoroutine("ChangeSize");
    }

    private void Death()
    {

    }

    //private IEnumerator ChangeSize()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}

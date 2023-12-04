using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sponsored by Professor Bruno Sweet

public class BrunoEnemyMover : MonoBehaviour
{
    Rigidbody2D goombaRb;
    bool walkingRight;
    public float goombaWalkSpeed;
    Vector2 walkDirection;
    // Start is called before the first frame update
    void Start()
    {
        goombaRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (walkingRight)
        {
            walkDirection = Vector2.right;
        }else if (!walkingRight)
        {
            walkDirection = Vector2.left;
        }

        goombaRb.velocity = walkDirection * goombaWalkSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        {
            walkingRight = !walkingRight;
        }
    }
}

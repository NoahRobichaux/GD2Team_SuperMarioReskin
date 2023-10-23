using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject goomba;
    public Rigidbody2D goombaRB;
    public float goombaWalkSpeed;
    public bool goombaWalkLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        goombaRB = goomba.GetComponentInChildren<Rigidbody2D>();
        goombaRB.velocity = Vector2.left * goombaWalkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        goombaWalkLeft = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == true)
        {
            goombaWalkLeft = false;
            goombaRB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == false)
        {
            goombaWalkLeft = true;
            goombaRB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == true)
        {
            goombaWalkLeft = false;
            goombaRB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == false)
        {
            goombaWalkLeft = true;
            goombaRB.velocity = Vector2.left * goombaWalkSpeed;
        }
    }
}

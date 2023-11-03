using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject goomba;
    public GameObject goomba1;
    public GameObject goomba2;
    public GameObject goomba3;
    public GameObject goomba4;
    public GameObject goomba5;
    public GameObject goomba6;
    public GameObject goomba7;
    public GameObject goomba8;
    public GameObject goomba9;
    public GameObject goomba10;
    public GameObject goomba11;
    public GameObject goomba12;
    public GameObject goomba13;
    public GameObject goomba14;
    public GameObject goomba15;

    public Rigidbody2D goombaRB;
    public Rigidbody2D goomba1RB;
    public Rigidbody2D goomba2RB;
    public Rigidbody2D goomba3RB;
    public Rigidbody2D goomba4RB;
    public Rigidbody2D goomba5RB;
    public Rigidbody2D goomba6RB;
    public Rigidbody2D goomba7RB;
    public Rigidbody2D goomba8RB;
    public Rigidbody2D goomba9RB;
    public Rigidbody2D goomba10RB;
    public Rigidbody2D goomba11RB;
    public Rigidbody2D goomba12RB;
    public Rigidbody2D goomba13RB;
    public Rigidbody2D goomba14RB;
    public Rigidbody2D goomba15RB;

    public float goombaWalkSpeed;
    public float goomba1WalkSpeed;
    public float goomba2WalkSpeed;
    public float goomba3WalkSpeed;
    public float goomba4WalkSpeed;
    public float goomba5WalkSpeed;
    public float goomba6WalkSpeed;
    public float goomba7WalkSpeed;
    public float goomba8WalkSpeed;
    public float goomba9WalkSpeed;
    public float goomba10WalkSpeed;
    public float goomba11WalkSpeed;
    public float goomba12WalkSpeed;
    public float goomba13WalkSpeed;
    public float goomba14WalkSpeed;
    public float goomba15WalkSpeed;

    public bool goombaWalkLeft = true;
    public bool goomba1WalkLeft = true;
    public bool goomba2WalkLeft = true;
    public bool goomba3WalkLeft = true;
    public bool goomba4WalkLeft = true;
    public bool goomba5WalkLeft = true;
    public bool goomba6WalkLeft = true;
    public bool goomba7WalkLeft = true;
    public bool goomba8WalkLeft = true;
    public bool goomba9WalkLeft = true;
    public bool goomba10WalkLeft = true;
    public bool goomba11WalkLeft = true;
    public bool goomba12WalkLeft = true;
    public bool goomba13WalkLeft = true;
    public bool goomba14WalkLeft = true;
    public bool goomba15WalkLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        goombaRB = goomba.GetComponent<Rigidbody2D>();
        goomba1RB = goomba.GetComponent<Rigidbody2D>();
        goomba2RB = goomba.GetComponent<Rigidbody2D>();
        goomba3RB = goomba.GetComponent<Rigidbody2D>();
        goomba4RB = goomba.GetComponent<Rigidbody2D>();
        goomba5RB = goomba.GetComponent<Rigidbody2D>();
        goomba6RB = goomba.GetComponent<Rigidbody2D>();
        goomba7RB = goomba.GetComponent<Rigidbody2D>();
        goomba8RB = goomba.GetComponent<Rigidbody2D>();
        goomba9RB = goomba.GetComponent<Rigidbody2D>();
        goomba10RB = goomba.GetComponent<Rigidbody2D>();
        goomba11RB = goomba.GetComponent<Rigidbody2D>();
        goomba12RB = goomba.GetComponent<Rigidbody2D>();
        goomba13RB = goomba.GetComponent<Rigidbody2D>();
        goomba14RB = goomba.GetComponent<Rigidbody2D>();
        goomba15RB = goomba.GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        goombaRB.velocity = Vector2.left * goombaWalkSpeed;
        goomba1RB.velocity = Vector2.left * goomba1WalkSpeed;
        goomba2RB.velocity = Vector2.left * goomba2WalkSpeed;
        goomba3RB.velocity = Vector2.left * goomba3WalkSpeed;
        goomba4RB.velocity = Vector2.left * goomba4WalkSpeed;
        goomba5RB.velocity = Vector2.left * goomba5WalkSpeed;
        goomba6RB.velocity = Vector2.left * goomba6WalkSpeed;
        goomba7RB.velocity = Vector2.left * goomba7WalkSpeed;
        goomba8RB.velocity = Vector2.left * goomba8WalkSpeed;
        goomba9RB.velocity = Vector2.left * goomba9WalkSpeed;
        goomba10RB.velocity = Vector2.left * goomba10WalkSpeed;
        goomba11RB.velocity = Vector2.left * goomba11WalkSpeed;
        goomba12RB.velocity = Vector2.left * goomba12WalkSpeed;
        goomba13RB.velocity = Vector2.left * goomba13WalkSpeed;
        goomba14RB.velocity = Vector2.left * goomba14WalkSpeed;
        goomba15RB.velocity = Vector2.left * goomba15WalkSpeed;
    }

    void Active()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == true)
        {
            goombaRB.velocity = Vector2.zero;
            goombaRB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == false)
        {
            goombaRB.velocity = Vector2.zero;
            goombaRB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == true)
        {
            goombaRB.velocity = Vector2.zero;
            goombaRB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == false)
        {
            goombaRB.velocity = Vector2.zero;
            goombaRB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba1WalkLeft == true)
        {
            goomba1RB.velocity = Vector2.right * goomba1WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba1WalkLeft == false)
        {
            goomba1RB.velocity = Vector2.left * goomba1WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == true)
        {
            goomba1RB.velocity = Vector2.right * goomba1WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == false)
        {
            goomba1RB.velocity = Vector2.left * goomba1WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == true)
        {
            goomba2RB.velocity = Vector2.right * goomba2WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == false)
        {
            goomba2RB.velocity = Vector2.left * goomba2WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == true)
        {
            goomba2RB.velocity = Vector2.right * goomba2WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == false)
        {
            goomba2RB.velocity = Vector2.left * goomba2WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == true)
        {
            goomba3RB.velocity = Vector2.right * goomba3WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == false)
        {
            goomba3RB.velocity = Vector2.left * goomba3WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == true)
        {
            goomba3RB.velocity = Vector2.right * goomba3WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == false)
        {
            goomba3RB.velocity = Vector2.left * goomba3WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == true)
        {
            goomba4RB.velocity = Vector2.right * goomba4WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == false)
        {
            goomba4RB.velocity = Vector2.left * goomba4WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == true)
        {
            goomba4RB.velocity = Vector2.right * goomba4WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == false)
        {
            goomba4RB.velocity = Vector2.left * goomba4WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == true)
        {
            goomba5RB.velocity = Vector2.right * goomba5WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == false)
        {
            goomba5RB.velocity = Vector2.left * goomba5WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == true)
        {
            goomba5RB.velocity = Vector2.right * goomba5WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == false)
        {
            goomba5RB.velocity = Vector2.left * goomba5WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == true)
        {
            goomba6RB.velocity = Vector2.right * goomba6WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == false)
        {
            goomba6RB.velocity = Vector2.left * goomba6WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == true)
        {
            goomba6RB.velocity = Vector2.right * goomba6WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == false)
        {
            goomba6RB.velocity = Vector2.left * goomba6WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == true)
        {
            goomba7RB.velocity = Vector2.right * goomba7WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == false)
        {
            goomba7RB.velocity = Vector2.left * goomba7WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == true)
        {
            goomba7RB.velocity = Vector2.right * goomba7WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == false)
        {
            goomba7RB.velocity = Vector2.left * goomba7WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == true)
        {
            goomba8RB.velocity = Vector2.right * goomba8WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == false)
        {
            goomba8RB.velocity = Vector2.left * goomba8WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == true)
        {
            goomba8RB.velocity = Vector2.right * goomba8WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == false)
        {
            goomba8RB.velocity = Vector2.left * goomba8WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == true)
        {
            goomba9RB.velocity = Vector2.right * goomba9WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == false)
        {
            goomba9RB.velocity = Vector2.left * goomba9WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == true)
        {
            goomba9RB.velocity = Vector2.right * goomba9WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == false)
        {
            goomba9RB.velocity = Vector2.left * goomba9WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == true)
        {
            goomba10RB.velocity = Vector2.right * goomba10WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == false)
        {
            goomba10RB.velocity = Vector2.left * goomba10WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == true)
        {
            goomba10RB.velocity = Vector2.right * goomba10WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == false)
        {
            goomba10RB.velocity = Vector2.left * goomba10WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == true)
        {
            goomba11RB.velocity = Vector2.right * goomba11WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == false)
        {
            goomba11RB.velocity = Vector2.left * goomba11WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == true)
        {
            goomba11RB.velocity = Vector2.right * goomba11WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == false)
        {
            goomba11RB.velocity = Vector2.left * goomba11WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == true)
        {
            goomba12RB.velocity = Vector2.right * goomba12WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == false)
        {
            goomba12RB.velocity = Vector2.left * goomba12WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == true)
        {
            goomba12RB.velocity = Vector2.right * goomba12WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == false)
        {
            goomba12RB.velocity = Vector2.left * goomba12WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == true)
        {
            goomba13RB.velocity = Vector2.right * goomba13WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == false)
        {
            goomba13RB.velocity = Vector2.left * goomba13WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == true)
        {
            goomba13RB.velocity = Vector2.right * goomba13WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == false)
        {
            goomba13RB.velocity = Vector2.left * goomba13WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == true)
        {
            goomba14RB.velocity = Vector2.right * goomba14WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == false)
        {
            goomba14RB.velocity = Vector2.left * goomba14WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == true)
        {
            goomba14RB.velocity = Vector2.right * goomba14WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == false)
        {
            goomba14RB.velocity = Vector2.left * goomba14WalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == true)
        {
            goomba15RB.velocity = Vector2.right * goomba15WalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == false)
        {
            goomba15RB.velocity = Vector2.left * goomba15WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == true)
        {
            goomba15RB.velocity = Vector2.right * goomba15WalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == false)
        {
            goomba15RB.velocity = Vector2.left * goomba15WalkSpeed;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == true)
        {
            goombaWalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goombaWalkLeft == false)
        {
            goombaWalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == true)
        {
            goombaWalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goombaWalkLeft == false)
        {
            goombaWalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba1WalkLeft == true)
        {
            goomba1WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba1WalkLeft == false)
        {
            goomba1WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == true)
        {
            goomba1WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == false)
        {
            goomba1WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == true)
        {
            goomba2WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == false)
        {
            goomba2WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == true)
        {
            goomba2WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == false)
        {
            goomba2WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == true)
        {
            goomba3WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == false)
        {
            goomba3WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == true)
        {
            goomba3WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == false)
        {
            goomba3WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == true)
        {
            goomba4WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == false)
        {
            goomba4WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == true)
        {
            goomba4WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == false)
        {
            goomba4WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == true)
        {
            goomba5WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == false)
        {
            goomba5WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == true)
        {
            goomba5WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == false)
        {
            goomba5WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == true)
        {
            goomba6WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == false)
        {
            goomba6WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == true)
        {
            goomba6WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == false)
        {
            goomba6WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == true)
        {
            goomba7WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == false)
        {
            goomba7WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == true)
        {
            goomba7WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == false)
        {
            goomba7WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == true)
        {
            goomba8WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == false)
        {
            goomba8WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == true)
        {
            goomba8WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == false)
        {
            goomba8WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == true)
        {
            goomba9WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == false)
        {
            goomba9WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == true)
        {
            goomba9WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == false)
        {
            goomba9WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == true)
        {
            goomba10WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == false)
        {
            goomba10WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == true)
        {
            goomba10WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == false)
        {
            goomba10WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == true)
        {
            goomba11WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == false)
        {
            goomba11WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == true)
        {
            goomba11WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == false)
        {
            goomba11WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == true)
        {
            goomba12WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == false)
        {
            goomba12WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == true)
        {
            goomba12WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == false)
        {
            goomba12WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == true)
        {
            goomba13WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == false)
        {
            goomba13WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == true)
        {
            goomba13WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == false)
        {
            goomba13WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == true)
        {
            goomba14WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == false)
        {
            goomba14WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == true)
        {
            goomba14WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == false)
        {
            goomba14WalkLeft = true;
        }

        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == true)
        {
            goomba15WalkLeft = false;
        }
        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == false)
        {
            goomba15WalkLeft = true;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == true)
        {
            goomba15WalkLeft = false;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == false)
        {
            goomba15WalkLeft = true;
        }
    }
}

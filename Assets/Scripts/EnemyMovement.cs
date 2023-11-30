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

    public float goombaWalkSpeed = 1.5f;

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

    public int collisionCount;

    // Start is called before the first frame update
    void Start()
    {
        goombaRB = goomba.GetComponent<Rigidbody2D>();
        goomba1RB = goomba1.GetComponent<Rigidbody2D>();
        goomba2RB = goomba2.GetComponent<Rigidbody2D>();
        goomba3RB = goomba3.GetComponent<Rigidbody2D>();
        goomba4RB = goomba4.GetComponent<Rigidbody2D>();
        goomba5RB = goomba5.GetComponent<Rigidbody2D>();
        goomba6RB = goomba6.GetComponent<Rigidbody2D>();
        goomba7RB = goomba7.GetComponent<Rigidbody2D>();
        goomba8RB = goomba8.GetComponent<Rigidbody2D>();
        goomba9RB = goomba9.GetComponent<Rigidbody2D>();
        goomba10RB = goomba10.GetComponent<Rigidbody2D>();
        goomba11RB = goomba11.GetComponent<Rigidbody2D>();
        goomba12RB = goomba12.GetComponent<Rigidbody2D>();
        goomba13RB = goomba13.GetComponent<Rigidbody2D>();
        goomba14RB = goomba14.GetComponent<Rigidbody2D>();
        goomba15RB = goomba15.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contactCount < 2)
        {
            collisionCount = collision.contactCount;

            goombaRB.velocity = Vector2.left * goombaWalkSpeed;
            goomba1RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba2RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba3RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba4RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba5RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba6RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba7RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba8RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba9RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba10RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba11RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba12RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba13RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba14RB.velocity = Vector2.left * goombaWalkSpeed;
            goomba15RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba1 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba2 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba3 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba4 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba5 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount --;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba6 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba7 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba8 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba9 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba10 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba11 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba12 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba13 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba14 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }
        if (collision.gameObject.tag == "Player" && PlayerController2.playerHitGoomba15 == true)
        {
            DeathBox.isPlayerDead = true;
            SpongeDollars.lifeCount--;
        }

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
            goomba1RB.velocity = Vector2.zero;
            goomba1RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba1WalkLeft == false)
        {
            goomba1RB.velocity = Vector2.zero;
            goomba1RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == true)
        {
            goomba1RB.velocity = Vector2.zero;
            goomba1RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba1WalkLeft == false)
        {
            goomba1RB.velocity = Vector2.zero;
            goomba1RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == true)
        {
            goomba2RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba2WalkLeft == false)
        {
            goomba2RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == true)
        {
            goomba2RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba2WalkLeft == false)
        {
            goomba2RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == true)
        {
            goomba3RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba3WalkLeft == false)
        {
            goomba3RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == true)
        {
            goomba3RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba3WalkLeft == false)
        {
            goomba3RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == true)
        {
            goomba4RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba4WalkLeft == false)
        {
            goomba4RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == true)
        {
            goomba4RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba4WalkLeft == false)
        {
            goomba4RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == true)
        {
            goomba5RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba5WalkLeft == false)
        {
            goomba5RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == true)
        {
            goomba5RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba5WalkLeft == false)
        {
            goomba5RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == true)
        {
            goomba6RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba6WalkLeft == false)
        {
            goomba6RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == true)
        {
            goomba6RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba6WalkLeft == false)
        {
            goomba6RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == true)
        {
            goomba7RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba7WalkLeft == false)
        {
            goomba7RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == true)
        {
            goomba7RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba7WalkLeft == false)
        {
            goomba7RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == true)
        {
            goomba8RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba8WalkLeft == false)
        {
            goomba8RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == true)
        {
            goomba8RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba8WalkLeft == false)
        {
            goomba8RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == true)
        {
            goomba9RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba9WalkLeft == false)
        {
            goomba9RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == true)
        {
            goomba9RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba9WalkLeft == false)
        {
            goomba9RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == true)
        {
            goomba10RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba10WalkLeft == false)
        {
            goomba10RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == true)
        {
            goomba10RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba10WalkLeft == false)
        {
            goomba10RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == true)
        {
            goomba11RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba11WalkLeft == false)
        {
            goomba11RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == true)
        {
            goomba11RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba11WalkLeft == false)
        {
            goomba11RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == true)
        {
            goomba12RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba12WalkLeft == false)
        {
            goomba12RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == true)
        {
            goomba12RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba12WalkLeft == false)
        {
            goomba12RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == true)
        {
            goomba13RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba13WalkLeft == false)
        {
            goomba13RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == true)
        {
            goomba13RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba13WalkLeft == false)
        {
            goomba13RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == true)
        {
            goomba14RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba14WalkLeft == false)
        {
            goomba14RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == true)
        {
            goomba14RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba14WalkLeft == false)
        {
            goomba14RB.velocity = Vector2.left * goombaWalkSpeed;
        }

        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == true)
        {
            goomba15RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Pipe" && goomba15WalkLeft == false)
        {
            goomba15RB.velocity = Vector2.left * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == true)
        {
            goomba15RB.velocity = Vector2.right * goombaWalkSpeed;
        }
        if (collision.gameObject.tag == "Goomba" && goomba15WalkLeft == false)
        {
            goomba15RB.velocity = Vector2.left * goombaWalkSpeed;
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

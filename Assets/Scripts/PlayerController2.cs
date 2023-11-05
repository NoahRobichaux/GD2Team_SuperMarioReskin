using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Goomba")
        {

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "QuestionBlock")
        {
            SpongeDollars.isBlockHit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (1)")
        {
            SpongeDollars.isBlock1Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (2)")
        {
            SpongeDollars.isBlock2Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (3)")
        {
            SpongeDollars.isBlock3Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (4)")
        {
            SpongeDollars.isBlock4Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (5)")
        {
            SpongeDollars.isBlock5Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (6)")
        {
            SpongeDollars.isBlock6Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (7)")
        {
            SpongeDollars.isBlock7Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (8)")
        {
            SpongeDollars.isBlock8Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (9)")
        {
            SpongeDollars.isBlock9Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (10)")
        {
            SpongeDollars.isBlock10Hit = true;
        }

        if (collision.gameObject.name == "QuestionBlock (11)")
        {
            SpongeDollars.isBlock11Hit = true;
        }
    }
}

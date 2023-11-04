using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpongeDollars : MonoBehaviour
{
    public GameObject questionBlock;
    public GameObject questionBlock1;
    public GameObject questionBlock2;
    public GameObject questionBlock3;
    public GameObject questionBlock4;
    public GameObject questionBlock5;
    public GameObject questionBlock6;
    public GameObject questionBlock7;
    public GameObject questionBlock8;
    public GameObject questionBlock9;
    public GameObject questionBlock10;
    public GameObject questionBlock11;

    public Rigidbody2D questionBlockRB;
    public Rigidbody2D questionBlockRB1;
    public Rigidbody2D questionBlockRB2;
    public Rigidbody2D questionBlockRB3;
    public Rigidbody2D questionBlockRB4;
    public Rigidbody2D questionBlockRB5;
    public Rigidbody2D questionBlockRB6;
    public Rigidbody2D questionBlockRB7;
    public Rigidbody2D questionBlockRB8;
    public Rigidbody2D questionBlockRB9;
    public Rigidbody2D questionBlockRB10;
    public Rigidbody2D questionBlockRB11;

    public TMP_Text scoreText;
    public TMP_Text coinCounter;

    public int score = 0;
    public int coinCount = 0;

    public static bool isBlockHit = false;
    public static bool isBlock1Hit = false;
    public static bool isBlock2Hit = false;
    public static bool isBlock3Hit = false;
    public static bool isBlock4Hit = false;
    public static bool isBlock5Hit = false;
    public static bool isBlock6Hit = false;
    public static bool isBlock7Hit = false;
    public static bool isBlock8Hit = false;
    public static bool isBlock9Hit = false;
    public static bool isBlock10Hit = false;
    public static bool isBlock11Hit = false;

    // Start is called before the first frame update
    void Start()
    {
        questionBlockRB = GetComponent<Rigidbody2D>();
        questionBlockRB1 = GetComponent<Rigidbody2D>();
        questionBlockRB2 = GetComponent<Rigidbody2D>();
        questionBlockRB3 = GetComponent<Rigidbody2D>();
        questionBlockRB4 = GetComponent<Rigidbody2D>();
        questionBlockRB5 = GetComponent<Rigidbody2D>();
        questionBlockRB6 = GetComponent<Rigidbody2D>();
        questionBlockRB7 = GetComponent<Rigidbody2D>();
        questionBlockRB8 = GetComponent<Rigidbody2D>();
        questionBlockRB9 = GetComponent<Rigidbody2D>();
        questionBlockRB10 = GetComponent<Rigidbody2D>();
        questionBlockRB11 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && isBlockHit == false)
        {
            score += 100;
            coinCount ++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock1Hit == false)
        {
            score += 100;
            coinCount ++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock2Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock3Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock4Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock5Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock6Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock7Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock8Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock9Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock10Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }

        if (collision.gameObject.tag == "Player" && isBlock11Hit == false)
        {
            score += 100;
            coinCount++;
            scoreText.SetText("" + score);
            coinCounter.SetText("x " + coinCount);
        }
    }
}

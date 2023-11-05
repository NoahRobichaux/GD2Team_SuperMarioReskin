using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpongeDollars : MonoBehaviour
{
    public GameObject questionBlock;

    public Rigidbody2D questionBlockRB;

    public TMP_Text scoreText;
    public TMP_Text coinCounter;

    public static int score = 0;
    public static int coinCount = 0;
    public static int lifeCount = 3;

    public GameObject gameOverSFX;
    public GameObject gameOverText;

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

    public GameObject gameManager;

    void Awake()
    {
        DontDestroyOnLoad(gameManager.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        questionBlockRB = GetComponent<Rigidbody2D>();
        scoreText.SetText("" + score);
        coinCounter.SetText("x " + coinCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeCount == 0)
        {
            gameOverSFX.SetActive(true);
            gameOverText.SetActive(true);
        }
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
    }
}

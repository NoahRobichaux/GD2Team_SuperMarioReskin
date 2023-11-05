using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpongeDollars : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text coinCounter;

    public static int score = 0;
    public static int coinCount = 0;
    public static int lifeCount = 3;

    public GameObject gameOverSFX;
    public GameObject gameOverText;

    public GameObject block;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;
    public GameObject block6;
    public GameObject block7;
    public GameObject block8;
    public GameObject block9;
    public GameObject block10;
    public GameObject block11;

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

    public static bool isBlockDisabled = false;
    public static bool isBlock1Disabled = false;
    public static bool isBlock2Disabled = false;
    public static bool isBlock3Disabled = false;
    public static bool isBlock4Disabled = false;
    public static bool isBlock5Disabled = false;
    public static bool isBlock6Disabled = false;
    public static bool isBlock7Disabled = false;
    public static bool isBlock8Disabled = false;
    public static bool isBlock9Disabled = false;
    public static bool isBlock10Disabled = false;
    public static bool isBlock11Disabled = false;

    public GameObject gameManager;

    void Awake()
    {
        DontDestroyOnLoad(gameManager.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.SetText("" + score);
        coinCounter.SetText("x " + coinCount);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("" + score);
        coinCounter.SetText("x " + coinCount);
        if (lifeCount == 0)
        {
            gameOverSFX.SetActive(true);
            gameOverText.SetActive(true);
        }

        if (isBlockHit == true && PlayerController2.playerHitBlock == true && isBlockDisabled == false)
        {
            score += 100;
            coinCount ++;
            Destroy(block.gameObject.GetComponent<SpongeDollars>());
            isBlockDisabled = true;
        }

        if (isBlock1Hit == true && PlayerController2.playerHitBlock1 == true && isBlock1Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block1.gameObject.GetComponent<SpongeDollars>());
            isBlock1Disabled = true;
        }

        if (isBlock2Hit == true && PlayerController2.playerHitBlock2 == true && isBlock2Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block2.gameObject.GetComponent<SpongeDollars>());
            isBlock2Disabled = true;
        }

        if (isBlock3Hit == true && PlayerController2.playerHitBlock3 == true && isBlock3Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block3.gameObject.GetComponent<SpongeDollars>());
            isBlock3Disabled = true;
        }

        if (isBlock4Hit == true && PlayerController2.playerHitBlock4 == true && isBlock4Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block4.gameObject.GetComponent<SpongeDollars>());
            isBlock4Disabled = true;
        }

        if (isBlock5Hit == true && PlayerController2.playerHitBlock5 == true && isBlock5Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block5.gameObject.GetComponent<SpongeDollars>());
            isBlock5Disabled = true;
        }

        if (isBlock6Hit == true && PlayerController2.playerHitBlock6 == true && isBlock6Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block6.gameObject.GetComponent<SpongeDollars>());
            isBlock6Disabled = true;
        }

        if (isBlock7Hit == true && PlayerController2.playerHitBlock7 == true && isBlock7Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block7.gameObject.GetComponent<SpongeDollars>());
            isBlock7Disabled = true;
        }

        if (isBlock8Hit == true && PlayerController2.playerHitBlock8 == true && isBlock8Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block8.gameObject.GetComponent<SpongeDollars>());
            isBlock8Disabled = true;
        }

        if (isBlock9Hit == true && PlayerController2.playerHitBlock9 == true && isBlock9Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block9.gameObject.GetComponent<SpongeDollars>());
            isBlock9Disabled = true;
        }

        if (isBlock10Hit == true && PlayerController2.playerHitBlock10 == true && isBlock10Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block10.gameObject.GetComponent<SpongeDollars>());
            isBlock10Disabled = true;
        }

        if (isBlock11Hit == true && PlayerController2.playerHitBlock11 == true && isBlock11Disabled == false)
        {
            score += 100;
            coinCount++;
            Destroy(block11.gameObject.GetComponent<SpongeDollars>());
            isBlock11Disabled = true;
        }
    }
}

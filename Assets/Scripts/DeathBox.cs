using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{
    public GameObject deathBox;
    public GameObject deathText;
    public GameObject deathSFX;
    public GameObject player;
    public SpriteRenderer playerSR;
    public GameObject uIHead;
    public GameObject uIHead1;
    public GameObject uIHead2;
    
    public static bool isPlayerDead = false;
    public bool didPlayerHitDBox = false;

    void Awake()
    {
        isPlayerDead = false;
        playerSR.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= -100 && didPlayerHitDBox == true && SpongeDollars.lifeCount > 0)
        {
            SceneManager.LoadScene(1);
        }
        if (player.transform.position.y <= -2300 && didPlayerHitDBox == true && SpongeDollars.lifeCount == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (isPlayerDead == true && SpongeDollars.lifeCount > 0)
        {
            deathText.SetActive(true);
            deathSFX.SetActive(true);
        }
        if (SpongeDollars.lifeCount == 2)
        {
            uIHead2.SetActive(false);
        }
        if (SpongeDollars.lifeCount == 1)
        {
            uIHead2.SetActive(false);
            uIHead1.SetActive(false);
        }
        if (SpongeDollars.lifeCount == 0)
        {
            uIHead2.SetActive(false);
            uIHead1.SetActive(false);
            uIHead.SetActive(false);
        }

        if (isPlayerDead == true && didPlayerHitDBox == true)
        {
            playerSR.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SpongeDollars.lifeCount --;
            isPlayerDead = true;
            didPlayerHitDBox = true;
        }
    }
}

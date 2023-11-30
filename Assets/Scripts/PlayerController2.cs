using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D playerRB;

    public float scene0LoadDelay;
    public float scene1LoadDelay;
    public float scene0LoadDelay2;

    public static bool isLevelComplete;

    public bool setPlayerInvis;
    
    public static bool playerHitBlock;
    public static bool playerHitBlock1;
    public static bool playerHitBlock2;
    public static bool playerHitBlock3;
    public static bool playerHitBlock4;
    public static bool playerHitBlock5;
    public static bool playerHitBlock6;
    public static bool playerHitBlock7;
    public static bool playerHitBlock8;
    public static bool playerHitBlock9;
    public static bool playerHitBlock10;
    public static bool playerHitBlock11;

    public static bool playerHitBrick;
    public static bool playerHitBrick1;
    public static bool playerHitBrick2;
    public static bool playerHitBrick3;
    public static bool playerHitBrick4;
    public static bool playerHitBrick5;
    public static bool playerHitBrick6;
    public static bool playerHitBrick7;
    public static bool playerHitBrick8;
    public static bool playerHitBrick9;
    public static bool playerHitBrick10;
    public static bool playerHitBrick11;
    public static bool playerHitBrick12;
    public static bool playerHitBrick13;
    public static bool playerHitBrick14;
    public static bool playerHitBrick15;
    public static bool playerHitBrick16;
    public static bool playerHitBrick17;
    public static bool playerHitBrick18;
    public static bool playerHitBrick19;
    public static bool playerHitBrick20;
    public static bool playerHitBrick21;
    public static bool playerHitBrick22;
    public static bool playerHitBrick23;
    public static bool playerHitBrick24;
    public static bool playerHitBrick25;
    public static bool playerHitBrick26;
    public static bool playerHitBrick27;
    public static bool playerHitBrick28;
    public static bool playerHitBrick29;
    public static bool playerHitBrick30;

    public static bool playerHitGoomba;
    public static bool playerKillGoomba;
    public static bool playerHitGoomba1;
    public static bool playerKillGoomba1;
    public static bool playerHitGoomba2;
    public static bool playerKillGoomba2;
    public static bool playerHitGoomba3;
    public static bool playerKillGoomba3;
    public static bool playerHitGoomba4;
    public static bool playerKillGoomba4;
    public static bool playerHitGoomba5;
    public static bool playerKillGoomba5;
    public static bool playerHitGoomba6;
    public static bool playerKillGoomba6;
    public static bool playerHitGoomba7;
    public static bool playerKillGoomba7;
    public static bool playerHitGoomba8;
    public static bool playerKillGoomba8;
    public static bool playerHitGoomba9;
    public static bool playerKillGoomba9;
    public static bool playerHitGoomba10;
    public static bool playerKillGoomba10;
    public static bool playerHitGoomba11;
    public static bool playerKillGoomba11;
    public static bool playerHitGoomba12;
    public static bool playerKillGoomba12;
    public static bool playerHitGoomba13;
    public static bool playerKillGoomba13;
    public static bool playerHitGoomba14;
    public static bool playerKillGoomba14;
    public static bool playerHitGoomba15;
    public static bool playerKillGoomba15;

    // Start is called before the first frame update
    void Start()
    {
        scene0LoadDelay = 22f;
        scene1LoadDelay = 3f;
        scene0LoadDelay2 = 3f;

        playerRB = GetComponent<Rigidbody2D>();
        playerRB.bodyType = RigidbodyType2D.Dynamic;
    }

    // Update is called once per frame
    void Update()
    {
        player.GetComponent<SpriteRenderer>().enabled = true;

        if (DeathBox.isPlayerDead == true && playerHitGoomba == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba1 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba1 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba2 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba2 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba3 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba3 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba4 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba4 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba5 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba5 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba6 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba6 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba7 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba7 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba8 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba8 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba9 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba9 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba10 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba10 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba11 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba11 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba12 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba12 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba13 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba13 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba14 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba14 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (DeathBox.isPlayerDead == true && playerHitGoomba15 == true && SpongeDollars.lifeCount > 0)
        {
            scene1LoadDelay -= Time.deltaTime;
        }
        if (DeathBox.isPlayerDead == true && playerHitGoomba15 == true && SpongeDollars.lifeCount <= 0)
        {
            scene0LoadDelay -= Time.deltaTime;
        }

        if (scene0LoadDelay <= 0 && SpongeDollars.lifeCount <= 0)
        {
            SceneManager.LoadScene(0);
        }
        if (scene1LoadDelay <= 0 && SpongeDollars.lifeCount > 0)
        {
            SceneManager.LoadScene(1);
        }
        if (scene0LoadDelay2 <= 0)
        {
            SceneManager.LoadScene(0);
        }

        if (playerHitGoomba)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba1)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba2)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba3)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba4)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba5)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba6)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba7)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba8)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba9)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba10)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba11)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba12)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba13)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba14)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (playerHitGoomba15)
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (setPlayerInvis)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (isLevelComplete)
        {
            scene0LoadDelay2 -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Goomba" && player.transform.position.y < 43.5)
        {
            playerHitGoomba = true;
        }
        if (collision.gameObject.name == "Goomba" && player.transform.position.y > 43.5)
        {
            playerKillGoomba = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (1)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba1 = true;
        }
        if (collision.gameObject.name == "Goomba (1)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba1 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (2)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba2 = true;
        }
        if (collision.gameObject.name == "Goomba (2)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba2 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (3)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba3 = true;
        }
        if (collision.gameObject.name == "Goomba (3)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba3 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (4)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba4 = true;
        }
        if (collision.gameObject.name == "Goomba (4)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba4 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (5)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba5 = true;
        }
        if (collision.gameObject.name == "Goomba (5)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba5 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (6)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba6 = true;
        }
        if (collision.gameObject.name == "Goomba (6)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba6 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (7)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba7 = true;
        }
        if (collision.gameObject.name == "Goomba (7)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba7 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (8)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba8 = true;
        }
        if (collision.gameObject.name == "Goomba (8)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba8 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (9)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba9 = true;
        }
        if (collision.gameObject.name == "Goomba (9)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba9 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (10)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba10 = true;
        }
        if (collision.gameObject.name == "Goomba (10)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba10 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (11)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba11 = true;
        }
        if (collision.gameObject.name == "Goomba (11)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba11 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (12)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba12 = true;
        }
        if (collision.gameObject.name == "Goomba (12)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba12 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (13)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba13 = true;
        }
        if (collision.gameObject.name == "Goomba (13)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba13 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (14)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba14 = true;
        }
        if (collision.gameObject.name == "Goomba (14)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba14 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }

        if (collision.gameObject.name == "Goomba (15)" && player.transform.position.y < 43.5)
        {
            playerHitGoomba15 = true;
        }
        if (collision.gameObject.name == "Goomba (15)" && player.transform.position.y > 43.5)
        {
            playerKillGoomba15 = true;
            Destroy(collision.gameObject);
            SpongeDollars.score += 100;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "QuestionBlock" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlockHit = true;
            playerHitBlock = true;
        }

        if (collision.gameObject.name == "QuestionBlock (1)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock1Hit = true;
            playerHitBlock1 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (2)" && player.transform.position.y < 50)
        {
            SpongeDollars.isBlock2Hit = true;
            playerHitBlock2 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (3)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock3Hit = true;
            playerHitBlock3 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (4)" && player.transform.position.y < 50)
        {
            SpongeDollars.isBlock4Hit = true;
            playerHitBlock4 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (5)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock5Hit = true;
            playerHitBlock5 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (6)" && player.transform.position.y < 50)
        {
            SpongeDollars.isBlock6Hit = true;
            playerHitBlock6 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (7)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock7Hit = true;
            playerHitBlock7 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (8)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock8Hit = true;
            playerHitBlock8 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (9)" && player.transform.position.y < 50)
        {
            SpongeDollars.isBlock9Hit = true;
            playerHitBlock9 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (10)" && player.transform.position.y < 50)
        {
            SpongeDollars.isBlock10Hit = true;
            playerHitBlock10 = true;
        }

        if (collision.gameObject.name == "QuestionBlock (11)" && player.transform.position.y < 46)
        {
            SpongeDollars.isBlock11Hit = true;
            playerHitBlock11 = true;
        }

        if (collision.gameObject.name == "Brick" && Bricks.isBrickDisabled == false)
        {
            Bricks.isBrickHit = true;
            playerHitBrick = true;
        }

        if (collision.gameObject.name  == "Brick (1)" && Bricks.isBrick1Disabled == false)
        {
            Bricks.isBrick1Hit = true;
            playerHitBrick1 = true;
        }

        if (collision.gameObject.name == "Brick (2)" && Bricks.isBrick2Disabled == false)
        {
            Bricks.isBrick2Hit = true;
            playerHitBrick2 = true;
        }

        if (collision.gameObject.name == "Brick (3)" && Bricks.isBrick3Disabled == false)
        {
            Bricks.isBrick3Hit = true;
            playerHitBrick3 = true;
        }

        if (collision.gameObject.name == "Brick (4)" && Bricks.isBrick4Disabled == false)
        {
            Bricks.isBrick4Hit = true;
            playerHitBrick4 = true;
        }

        if (collision.gameObject.name == "Brick (5)" && Bricks.isBrick5Disabled == false)
        {
            Bricks.isBrick5Hit = true;
            playerHitBrick5 = true;
        }

        if (collision.gameObject.name == "Brick (6)" && Bricks.isBrick6Disabled == false)
        {
            Bricks.isBrick6Hit = true;
            playerHitBrick6 = true;
        }

        if (collision.gameObject.name == "Brick (7)" && Bricks.isBrick7Disabled == false)
        {
            Bricks.isBrick7Hit = true;
            playerHitBrick7 = true;
        }

        if (collision.gameObject.name == "Brick (8)" && Bricks.isBrick8Disabled == false)
        {
            Bricks.isBrick8Hit = true;
            playerHitBrick8 = true;
        }

        if (collision.gameObject.name == "Brick (9)" && Bricks.isBrick9Disabled == false)
        {
            Bricks.isBrick9Hit = true;
            playerHitBrick9 = true;
        }

        if (collision.gameObject.name == "Brick (10)" && Bricks.isBrick10Disabled == false)
        {
            Bricks.isBrick10Hit = true;
            playerHitBrick10 = true;
        }

        if (collision.gameObject.name == "Brick (11)" && Bricks.isBrick11Disabled == false)
        {
            Bricks.isBrick11Hit = true;
            playerHitBrick11 = true;
        }

        if (collision.gameObject.name == "Brick (12)" && Bricks.isBrick12Disabled == false)
        {
            Bricks.isBrick12Hit = true;
            playerHitBrick12 = true;
        }

        if (collision.gameObject.name == "Brick (13)" && Bricks.isBrick13Disabled == false)
        {
            Bricks.isBrick13Hit = true;
            playerHitBrick13 = true;
        }

        if (collision.gameObject.name == "Brick (14)" && Bricks.isBrick14Disabled == false)
        {
            Bricks.isBrick14Hit = true;
            playerHitBrick14 = true;
        }

        if (collision.gameObject.name == "Brick (15)" && Bricks.isBrick15Disabled == false)
        {
            Bricks.isBrick15Hit = true;
            playerHitBrick15 = true;
        }

        if (collision.gameObject.name == "Brick (16)" && Bricks.isBrick16Disabled == false)
        {
            Bricks.isBrick16Hit = true;
            playerHitBrick16 = true;
        }

        if (collision.gameObject.name == "Brick (17)" && Bricks.isBrick17Disabled == false)
        {
            Bricks.isBrick17Hit = true;
            playerHitBrick17 = true;
        }

        if (collision.gameObject.name == "Brick (18)" && Bricks.isBrick18Disabled == false)
        {
            Bricks.isBrick18Hit = true;
            playerHitBrick18 = true;
        }

        if (collision.gameObject.name == "Brick (19)" && Bricks.isBrick19Disabled == false)
        {
            Bricks.isBrick19Hit = true;
            playerHitBrick19 = true;
        }

        if (collision.gameObject.name == "Brick (20)" && Bricks.isBrick20Disabled == false)
        {
            Bricks.isBrick20Hit = true;
            playerHitBrick20 = true;
        }

        if (collision.gameObject.name == "Brick (21)" && Bricks.isBrick21Disabled == false)
        {
            Bricks.isBrick21Hit = true;
            playerHitBrick21 = true;
        }

        if (collision.gameObject.name == "Brick (22)" && Bricks.isBrick22Disabled == false)
        {
            Bricks.isBrick22Hit = true;
            playerHitBrick22 = true;
        }

        if (collision.gameObject.name == "Brick (23)" && Bricks.isBrick23Disabled == false)
        {
            Bricks.isBrick23Hit = true;
            playerHitBrick23 = true;
        }

        if (collision.gameObject.name == "Brick (24)" && Bricks.isBrick24Disabled == false)
        {
            Bricks.isBrick24Hit = true;
            playerHitBrick24 = true;
        }

        if (collision.gameObject.name == "Brick (25)" && Bricks.isBrick25Disabled == false)
        {
            Bricks.isBrick25Hit = true;
            playerHitBrick25 = true;
        }

        if (collision.gameObject.name == "Brick (26)" && Bricks.isBrick26Disabled == false)
        {
            Bricks.isBrick26Hit = true;
            playerHitBrick26 = true;
        }

        if (collision.gameObject.name == "Brick (27)" && Bricks.isBrick27Disabled == false)
        {
            Bricks.isBrick27Hit = true;
            playerHitBrick27 = true;
        }

        if (collision.gameObject.name == "Brick (28)" && Bricks.isBrick28Disabled == false)
        {
            Bricks.isBrick28Hit = true;
            playerHitBrick28 = true;
        }

        if (collision.gameObject.name == "Brick (29)" && Bricks.isBrick29Disabled == false)
        {
            Bricks.isBrick29Hit = true;
            playerHitBrick29 = true;
        }

        if (collision.gameObject.name == "Brick (30)" && Bricks.isBrick30Disabled == false)
        {
            Bricks.isBrick30Hit = true;
            playerHitBrick30 = true;
        }

        if (collision.gameObject.tag == "EndBoundary")
        {
            isLevelComplete = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "EndTrigger")
        {
            setPlayerInvis = true;
        }
    }
}

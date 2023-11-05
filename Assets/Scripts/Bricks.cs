using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject player;

    public GameObject brick;
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick4;
    public GameObject brick5;
    public GameObject brick6;
    public GameObject brick7;
    public GameObject brick8;
    public GameObject brick9;
    public GameObject brick10;
    public GameObject brick11;
    public GameObject brick12;
    public GameObject brick13;
    public GameObject brick14;
    public GameObject brick15;
    public GameObject brick16;
    public GameObject brick17;
    public GameObject brick18;
    public GameObject brick19;
    public GameObject brick20;
    public GameObject brick21;
    public GameObject brick22;
    public GameObject brick23;
    public GameObject brick24;
    public GameObject brick25;
    public GameObject brick26;
    public GameObject brick27;
    public GameObject brick28;
    public GameObject brick29;
    public GameObject brick30;

    public static bool isBrickHit;
    public static bool isBrickDisabled;
    public static bool isBrick1Hit;
    public static bool isBrick1Disabled;
    public static bool isBrick2Hit;
    public static bool isBrick2Disabled;
    public static bool isBrick3Hit;
    public static bool isBrick3Disabled;
    public static bool isBrick4Hit;
    public static bool isBrick4Disabled;
    public static bool isBrick5Hit;
    public static bool isBrick5Disabled;
    public static bool isBrick6Hit;
    public static bool isBrick6Disabled;
    public static bool isBrick7Hit;
    public static bool isBrick7Disabled;
    public static bool isBrick8Hit;
    public static bool isBrick8Disabled;
    public static bool isBrick9Hit;
    public static bool isBrick9Disabled;
    public static bool isBrick10Hit;
    public static bool isBrick10Disabled;
    public static bool isBrick11Hit;
    public static bool isBrick11Disabled;
    public static bool isBrick12Hit;
    public static bool isBrick12Disabled;
    public static bool isBrick13Hit;
    public static bool isBrick13Disabled;
    public static bool isBrick14Hit;
    public static bool isBrick14Disabled;
    public static bool isBrick15Hit;
    public static bool isBrick15Disabled;
    public static bool isBrick16Hit;
    public static bool isBrick16Disabled;
    public static bool isBrick17Hit;
    public static bool isBrick17Disabled;
    public static bool isBrick18Hit;
    public static bool isBrick18Disabled;
    public static bool isBrick19Hit;
    public static bool isBrick19Disabled;
    public static bool isBrick20Hit;
    public static bool isBrick20Disabled;
    public static bool isBrick21Hit;
    public static bool isBrick21Disabled;
    public static bool isBrick22Hit;
    public static bool isBrick22Disabled;
    public static bool isBrick23Hit;
    public static bool isBrick23Disabled;
    public static bool isBrick24Hit;
    public static bool isBrick24Disabled;
    public static bool isBrick25Hit;
    public static bool isBrick25Disabled;
    public static bool isBrick26Hit;
    public static bool isBrick26Disabled;
    public static bool isBrick27Hit;
    public static bool isBrick27Disabled;
    public static bool isBrick28Hit;
    public static bool isBrick28Disabled;
    public static bool isBrick29Hit;
    public static bool isBrick29Disabled;
    public static bool isBrick30Hit;
    public static bool isBrick30Disabled;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBrickHit == true && PlayerController2.playerHitBrick == true && isBrickDisabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick.gameObject);
            isBrickDisabled = true;
        }

        if (isBrick1Hit == true && PlayerController2.playerHitBrick1 == true && isBrick1Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick1.gameObject);
            isBrick1Disabled = true;
        }

        if (isBrick2Hit == true && PlayerController2.playerHitBrick2 == true && isBrick2Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick2.gameObject);
            isBrick2Disabled = true;
        }

        if (isBrick3Hit == true && PlayerController2.playerHitBrick3 == true && isBrick3Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick3.gameObject);
            isBrick3Disabled = true;
        }

        if (isBrick4Hit == true && PlayerController2.playerHitBrick4 == true && isBrick4Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick4.gameObject);
            isBrick4Disabled = true;
        }

        if (isBrick5Hit == true && PlayerController2.playerHitBrick5 == true && isBrick5Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick5.gameObject);
            isBrick5Disabled = true;
        }

        if (isBrick6Hit == true && PlayerController2.playerHitBrick6 == true && isBrick6Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick6.gameObject);
            isBrick6Disabled = true;
        }

        if (isBrick7Hit == true && PlayerController2.playerHitBrick7 == true && isBrick7Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick7.gameObject);
            isBrick7Disabled = true;
        }

        if (isBrick8Hit == true && PlayerController2.playerHitBrick8 == true && isBrick8Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick8.gameObject);
            isBrick8Disabled = true;
        }

        if (isBrick9Hit == true && PlayerController2.playerHitBrick9 == true && isBrick9Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick9.gameObject);
            isBrick9Disabled = true;
        }

        if (isBrick10Hit == true && PlayerController2.playerHitBrick10 == true && isBrick10Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick10.gameObject);
            isBrick10Disabled = true;
        }

        if (isBrick11Hit == true && PlayerController2.playerHitBrick11 == true && isBrick11Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick11.gameObject);
            isBrick11Disabled = true;
        }

        if (isBrick12Hit == true && PlayerController2.playerHitBrick12 == true && isBrick12Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick12.gameObject);
            isBrick12Disabled = true;
        }

        if (isBrick13Hit == true && PlayerController2.playerHitBrick13 == true && isBrick13Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick13.gameObject);
            isBrick13Disabled = true;
        }

        if (isBrick14Hit == true && PlayerController2.playerHitBrick14 == true && isBrick14Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick14.gameObject);
            isBrick14Disabled = true;
        }

        if (isBrick15Hit == true && PlayerController2.playerHitBrick15 == true && isBrick15Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick15.gameObject);
            isBrick15Disabled = true;
        }

        if (isBrick16Hit == true && PlayerController2.playerHitBrick16 == true && isBrick16Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick16.gameObject);
            isBrick16Disabled = true;
        }

        if (isBrick17Hit == true && PlayerController2.playerHitBrick17 == true && isBrick17Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick17.gameObject);
            isBrick17Disabled = true;
        }

        if (isBrick18Hit == true && PlayerController2.playerHitBrick18 == true && isBrick18Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick18.gameObject);
            isBrick18Disabled = true;
        }

        if (isBrick19Hit == true && PlayerController2.playerHitBrick19 == true && isBrick19Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick19.gameObject);
            isBrick19Disabled = true;
        }

        if (isBrick20Hit == true && PlayerController2.playerHitBrick20 == true && isBrick20Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick20.gameObject);
            isBrick20Disabled = true;
        }

        if (isBrick21Hit == true && PlayerController2.playerHitBrick21 == true && isBrick21Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick21.gameObject);
            isBrick21Disabled = true;
        }

        if (isBrick22Hit == true && PlayerController2.playerHitBrick22 == true && isBrick22Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick22.gameObject);
            isBrick22Disabled = true;
        }

        if (isBrick23Hit == true && PlayerController2.playerHitBrick23 == true && isBrick23Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick23.gameObject);
            isBrick23Disabled = true;
        }

        if (isBrick24Hit == true && PlayerController2.playerHitBrick24 == true && isBrick24Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick24.gameObject);
            isBrick24Disabled = true;
        }

        if (isBrick25Hit == true && PlayerController2.playerHitBrick25 == true && isBrick25Disabled == false && player.transform.position.y < 50)
        {
            SpongeDollars.score += 10;
            Destroy(brick25.gameObject);
            isBrick25Disabled = true;
        }

        if (isBrick26Hit == true && PlayerController2.playerHitBrick26 == true && isBrick26Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick26.gameObject);
            isBrick26Disabled = true;
        }

        if (isBrick27Hit == true && PlayerController2.playerHitBrick27 == true && isBrick27Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick27.gameObject);
            isBrick27Disabled = true;
        }

        if (isBrick28Hit == true && PlayerController2.playerHitBrick28 == true && isBrick28Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick28.gameObject);
            isBrick28Disabled = true;
        }

        if (isBrick29Hit == true && PlayerController2.playerHitBrick29 == true && isBrick29Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick29.gameObject);
            isBrick29Disabled = true;
        }

        if (isBrick30Hit == true && PlayerController2.playerHitBrick30 == true && isBrick30Disabled == false && player.transform.position.y < 46)
        {
            SpongeDollars.score += 10;
            Destroy(brick30.gameObject);
            isBrick30Disabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOverBG : MonoBehaviour
{
    public GameObject gameOverBG;
    public SpriteRenderer gameOverBGRenderer;
    public GameObject gameOverText;

    public float alpha;
    public float textActivateDelay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SpongeDollars.lifeCount == 0)
        {
            textActivateDelay -= Time.deltaTime;
            alpha += Time.deltaTime;
            gameOverBGRenderer.color = new Color(0f, 0f, 0f, alpha);
            if (textActivateDelay <= 0)
            {
                gameOverText.SetActive(true);
            }
        }
    }
}

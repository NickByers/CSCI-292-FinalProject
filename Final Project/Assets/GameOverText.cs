using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    // Start is called before the first frame update
    public static TextMeshProUGUI Text;
    private static Image image;
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
        Text.text = "  ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GameOver()
    {
        Text.text = " Game Over! \n Remaining Health: " + (BlackHole._Health / BlackHole._MaxHealth) * 100f + "% \n Press ENTER to Restart";      
        GameObject health = GameObject.Find("HealthbarInner");
        image = health.GetComponent<Image>();
        image.enabled = false;

        health = GameObject.Find("Healthbar");
        image = health.GetComponent<Image>();
        image.enabled = false;

    }

    public static void PlayerWon()
    {
        Text.text = "You Win!";
    }
}

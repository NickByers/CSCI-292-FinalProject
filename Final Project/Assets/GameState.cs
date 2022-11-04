using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsOver = false;
    //public Text health;
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { 
        if (GameIsOver)
        {

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1;
                GameIsOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                GameOverText.Text.text = " ";
            }
            EndGame();
        }
        if(BlackHole._Health == 0)
        {
            PlayerWon();
            GameOverText.PlayerWon();
        }
    }

    void ChangeFOV(){

        if (Camera.main.orthographicSize > 1)
            Camera.main.orthographicSize -= 0.05f;
    }

    void EndGame()
    {
        Time.timeScale = 0;
        ChangeFOV();
        GameOverText.GameOver();
    }



    void PlayerWon() {
        Debug.Log("Player Won!");
    }
}

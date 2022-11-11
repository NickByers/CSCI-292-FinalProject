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
            EndGame();
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1;
                GameIsOver = false;
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                GameOverText.Text.text = " ";
                BlackHole._Health = BlackHole._MaxHealth;
            }
        }
        if(BlackHole._Health <= 0)
        {
            PlayerWon();
            GameOverText.PlayerWon();
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1;
                GameIsOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                GameOverText.Text.text = " ";
                BlackHole._Health = BlackHole._MaxHealth;
            }
        }
    }
    // ChangeFOV zooms camera if player loses
    void ZoomInFOV(){ 
     

        if (Camera.main.orthographicSize > 1)
            Camera.main.orthographicSize -= 0.05f;
    }

    void ZoomOutFOV()
    {
        Camera.main.transform.position = Vector3.forward;
    }


    void EndGame()
    {
        Time.timeScale = 0;
        ZoomInFOV();
        GameOverText.GameOver();
    }



    void PlayerWon() {
        Time.timeScale = 0;
        ZoomOutFOV();
        Debug.Log("Player Won!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
        {
            ChangeFOV();
            Time.timeScale = 0;
            GameObject.Find("GameOverText").SetActive(true);
        }
    }

    void ChangeFOV(){

        if (Camera.main.orthographicSize > 1)
            Camera.main.orthographicSize -= 0.05f;
    }
}

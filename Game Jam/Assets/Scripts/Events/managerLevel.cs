using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class managerLevel : MonoBehaviour
{
    public Text gameOverText;
    public PlayerL playerController;

    private bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
      playerController.OnHitKillzone += OnGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            return;
        }

    }
    private void OnGameOver()
    {
        gameOver = true;

        gameOverText.enabled = true;

        gameOverText.text = "Game over!\nPress R to restart";

        Time.timeScale = 0;
    }
}

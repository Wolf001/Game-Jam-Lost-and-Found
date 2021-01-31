using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool isGameActive;
	public void StartGame(float difficulty)
	{
		isGameActive = true;
	}

	public void GameOver()
	{
		isGameActive = false;
		//Do Something
	}

	public void RestartScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

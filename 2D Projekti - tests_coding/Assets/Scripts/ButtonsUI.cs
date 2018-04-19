using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonsUI : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
            if(GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
        }
	}
	
	
	public void StartScreen()
	{
		SceneManager.LoadScene(0);
	}
	
	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}
	
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	
	public void QuitGame()
	{
        print("You quit the game!");
		Application.Quit();
	}
}
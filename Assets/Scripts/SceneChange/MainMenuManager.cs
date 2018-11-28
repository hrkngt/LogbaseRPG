using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
	public GameObject MainMenu;
	
	public void Play()
	{
		MainMenu.SetActive(false);
		SceneManager.LoadScene("SampleGame");
	}

	public void Quit()
	{
		Application.Quit();
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
	public GameObject mainMenuPanel;
	public GameObject playMenuPanel;

	public GameObject easyTab;
	public GameObject normalTab;
	public GameObject hardTab;

	public Color activeColor;
	public Color inactiveColor;



	void Awake()
	{
		playMenuPanel.SetActive(true);
	}



	public void PlayGame(int difficulty)
	{
		PlayerPrefs.SetInt("Difficulty", difficulty);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	
	void ChangeTabLabel(Difficulty difficulty)
	{
		easyTab.GetComponent<Image>().color = inactiveColor;
		normalTab.GetComponent<Image>().color = inactiveColor;
		hardTab.GetComponent<Image>().color = inactiveColor;

		switch (difficulty)
		{
			case Difficulty.EASY:
				easyTab.GetComponent<Image>().color = activeColor;
				break;
			case Difficulty.NORMAL:
				normalTab.GetComponent<Image>().color = activeColor;
				break;
			case Difficulty.HARD:
				hardTab.GetComponent<Image>().color = activeColor;
				break;
			default:
				normalTab.GetComponent<Image>().color = activeColor;
				break;
		}
	}
}

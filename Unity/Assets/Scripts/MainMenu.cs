using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Button practiceMode;
	public Button enterSkillzMode;

	void Awake ()
	{
		// Button practiceModeButton = practiceMode.GetComponent<Button>();
		// if (practiceModeButton==null)
		// {
		// 	Debug.Log("cant find pratice mode button");
		// }
		// Button enterSkillzModeButton = enterSkillzMode.GetComponent<Button>();
		// if (enterSkillzModeButton==null)
		// {
		// 	Debug.Log("cant find skillz mode button");
		// }

		practiceMode.onClick.AddListener(PracticeMode);
		enterSkillzMode.onClick.AddListener(EnterSkillzMode);

	}

	void Update ()
	{

	}

	public void PracticeMode()
	{
		Debug.Log("load practice");
		SceneManager.LoadScene("Game");
	}

	public void EnterSkillzMode()
	{
		// jane - update this
		Debug.Log("load skillz");
		SceneManager.LoadScene("Game");
	}
}

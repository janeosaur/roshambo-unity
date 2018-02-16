using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Button Rock;
	public Button Paper;
	public Button Scissors;

	public GameObject draw;
	public GameObject win;
	public GameObject lose;

	bool isGameOver;

	int random;

	public enum Clicked {
		Rock,
		Paper,
		Scissors,
		None
	}

	public Clicked ClickedPlay;

	void Awake ()
	{
		Button rockButton = Rock.GetComponent<Button>();
		Button paperButton = Paper.GetComponent<Button>();
		Button scissorsButton = Scissors.GetComponent<Button>();

		rockButton.onClick.AddListener(PlayRock);
		paperButton.onClick.AddListener(PlayPaper);
		scissorsButton.onClick.AddListener(PlayScissors);

		draw.SetActive(false);
		win.SetActive(false);
		lose.SetActive(false);

		isGameOver = false;

		// 1 = rock. 2 = paper. 3 = scissors

		random = Random.Range(1,3); // update this jane
		ClickedPlay = Clicked.None;
	}

	// Update is called once per frame
	void Update () {
		switch (ClickedPlay)
		{
			case Clicked.Rock:
			{
				switch (random)
				{
					case 1:
					{
						if (!isGameOver)
						{
							Draw();
						}
						break;
					}
					case 2:
					{
						if (!isGameOver)
						{
							Player2Wins();
						}
						break;
					}
					case 3:
					{
						if (!isGameOver)
						{
							Player1Wins();
						}
						break;
					}
				}
				break;
			}
			case Clicked.Paper:
			{
				switch (random)
				{
					case 1:
					{
						if (!isGameOver)
						{
							Player1Wins();
						}
						break;
					}
					case 2:
					{
						if (!isGameOver)
						{
							Draw();
						}
						break;
					}
					case 3:
					{
						if (!isGameOver)
						{
							Player2Wins();
						}
						break;
					}
				}
				break;
			}
			case Clicked.Scissors:
			{
				switch (random)
				{
					case 1:
					{
						if (!isGameOver)
						{
							Player2Wins();
						}
						break;
					}
					case 2:
					{
						if (!isGameOver)
						{
							Player1Wins();
						}
						break;
					}
					case 3:
					{
						if (!isGameOver)
						{
							Draw();
						}
						break;
					}
				}
				break;
			}
		}

	}

	IEnumerator Restart () {
		yield return new WaitForSeconds(2f);
		Awake();
	}

	void Draw () {
		isGameOver = true;
		draw.SetActive(true);
		StartCoroutine(Restart());
	}


	void Player1Wins () {
		isGameOver = true;
		win.SetActive(true);
		StartCoroutine(Restart());
	}

	void Player2Wins () {
		isGameOver = true;
		lose.SetActive(true);
		StartCoroutine(Restart());
	}

	void PlayRock () {
		ClickedPlay = Clicked.Rock;
	}

	void PlayPaper () {
		ClickedPlay = Clicked.Paper;
	}

	void PlayScissors () {
		ClickedPlay = Clicked.Scissors;
	}
}

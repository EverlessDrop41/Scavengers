using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoardManager))]
public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public BoardManager boardScript;
	public int playerFoodPoints = 100;
	[HideInInspector] public bool playersTurn = true;

	private int level = 3;

	void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(this.gameObject);

		DontDestroyOnLoad(this.gameObject);

		boardScript = GetComponent<BoardManager>();
		boardScript.SetupScene(level);
		//InitGame();
	}

	void Start() {
		Awake();
	}

	void InitGame(){
		boardScript.SetupScene(level);
	}

	public void GameOver() {
		enabled = false;
	}
}

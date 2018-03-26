using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	//Variaveis para alocar os dois texts criados
	public Text scoreText;
	public Text timeText;
	public float playTime;

	//Painel de vitória/derrota/impate

	public GameObject EndGamePanel;
	public Text GreenWin;
	public Text RedWin;
	public Text NoneWin;
	public Text TankText;

	public GameObject ammoPickup;

	//public Text textGreenScore;
	//public Text textRedScore;

	public Transform[] ammoSpawnPoint;
	public float ammoSpawnTime;

	public static int score;

	float currentTime;

	public void Rematch() {
		Time.timeScale = 1;
		Application.LoadLevel("Level01");
	}

	public void Menu () {
	Application.LoadLevel("MainMenu");
	}

	// Use this for initialization
	void Start () {
		EndGamePanel.SetActive (false); 
		InvokeRepeating ("SpawnAmmoPickup", ammoSpawnTime, ammoSpawnTime);
		//score = 0;
		playTime = PlayerPrefs.GetFloat("playTime");
		Time.timeScale = 1;
	
	}

	void SpawnAmmoPickup() {
		int i = Random.Range(0,4);
		Instantiate(ammoPickup,
		            ammoSpawnPoint[i].position,
		            ammoSpawnPoint[i].rotation);

	}

	void EndGame() {
		Time.timeScale = 0;
		EndGamePanel.SetActive (true); 
		if (RocketScript.scoreTankRed > RocketScript.scoreTankGreen) {
			RedWin.enabled = true;
			GreenWin.enabled = false;
			NoneWin.enabled = false;
			TankText.enabled = true;
		  }
		if (RocketScript.scoreTankGreen > RocketScript.scoreTankRed) {
			RedWin.enabled = false;
			GreenWin.enabled = true;
			NoneWin.enabled = false;
			TankText.enabled = true;
		  }
		if (RocketScript.scoreTankGreen == RocketScript.scoreTankRed) {
			RedWin.enabled = false;
			GreenWin.enabled = false;
			NoneWin.enabled = true;
			TankText.enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;
		if (currentTime >= playTime) {
		EndGame();
		 }
		//currentTime = currentTime + Time.deltaTime; 

		timeText.text = "Time: " + ((int)currentTime).ToString();
	}
}

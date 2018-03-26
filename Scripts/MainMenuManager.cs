using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//para Uity 5 ou + //using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public Text playTimeText;

	float playTime;

	//Função para iniciar o jogo (chamamos ela pelo botão Start Game)
	public void StartGame()  {

		//Para unity 4
		Application.LoadLevel ("Level01");
		//para Unity 5 ou +
		//SceneManager.LoadScene("Level01");

	}

	public void Play1Min() {
		playTime = 60.0f;
		playTimeText.text = "Play time = 1 min.";
		PlayerPrefs.SetFloat ("playTime", playTime);
	}

	public void Play3Min() {
		playTime = 180.0f;
		playTimeText.text = "Play time = 3 min.";
		PlayerPrefs.SetFloat ("playTime", playTime);
	}

	public void Play5Min() {
		playTime = 300.0f;
		playTimeText.text = "Play time = 5 min.";
		PlayerPrefs.SetFloat ("playTime", playTime);
	}


	//Função para sair do jogo (chamamos ela pelo botão Quit Game)
	public void QuitGame()  {

	}
}

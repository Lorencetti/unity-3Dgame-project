using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CannonScript : MonoBehaviour {

	public int inicialAmmo;
	private int ammo;
	public Text textAmmo;
	public Text textGreenScore;
	public Text textRedScore;

	//Armazena o nome do botao de tiro
	public string fireButtonName;

	//Armazena o ponto onde o rocket sera criado
	public Transform rocketSlot;

	//Armazena o GameObject rocket (o missil) para ser instanciado.
	public GameObject rocket;

	void Start () {
		textAmmo.text = "Ammo : " + inicialAmmo.ToString();
		ammo = inicialAmmo;
	}

	// Update is called once per frame
	void Update () {
		textGreenScore.text = "Score : " + RocketScript.scoreTankGreen.ToString();
		textRedScore.text = "Score : " + RocketScript.scoreTankRed.ToString();
	

		//Verifica se o player pressionou o botao de tiro adequado
		if (Input.GetButtonDown (fireButtonName) && (ammo > 0)) {
			//Instancia um rocket na posiçao em que esta o gameObject rocketSlot
			Instantiate (rocket, rocketSlot.transform.position, rocketSlot.transform.rotation);
			ammo = ammo - 1;
			textAmmo.text = "Ammo : " + ammo.ToString ();
		}

	
	}

	void OnTriggerEnter(Collider other) {
		 
		if (other.gameObject.tag == "AmmoPickup") {
		ammo = ammo + 10;
		Destroy(other.gameObject);
		textAmmo.text = "Ammo : " + ammo.ToString ();
		}
	}
}

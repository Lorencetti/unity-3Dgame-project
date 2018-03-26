using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

	//Variaveis que armazenam a velocidade do tanque 
	public float tankSpeed;
	public float tankTurnSpeed;

	//Variaveis que armazenam o nome dos eixos
	public string horizontalAxisName;
	public string verticalAxisName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//As duas variaveis recebem a leitura dos eixos vertical e horizontal
		float horizontalAxis = Input.GetAxis (horizontalAxisName);
		float verticalAxis = Input.GetAxis (verticalAxisName);

		//Os valores da leitura dos eixos sao usado nas funçoes Tranlate e Rotate, para mover o tanque
		transform.Translate (tankSpeed * verticalAxis * Time.deltaTime, 0, 0);
		transform.Rotate (0.0f, tankTurnSpeed * horizontalAxis * Time.deltaTime, 0.0f);
	}
}

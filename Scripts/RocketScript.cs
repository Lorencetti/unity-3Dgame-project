using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RocketScript : MonoBehaviour {

	public static int  scoreTankRed;
	public static int  scoreTankGreen;

	//Armazena a particula da explosao
	public ParticleSystem targetExplosion;
	public ParticleSystem tankExplosion;

	//Armazena a velocidade do rocket
	public float rocketSpeed;

	public Text textGreenScore;
	public Text textRedScore;


	void start () {
		scoreTankRed = 0;
		scoreTankGreen = 0;
	}

	// Update is called once per frame
	void Update () {

		//Faz o rocket transladar com a velocidade rocketSpeed no eixo x positivo. 
		transform.Translate (rocketSpeed * Time.deltaTime, 0, 0);
	
	}

	//Funcao que detecta a colisao entre dois colisores
	void OnTriggerEnter(Collider other) 
	{
		//Verifica se a tag do objeto que colidiu e igual a "Target"
		if (other.gameObject.tag == "Target") 
		{
			//Destroi o objeto que o rocket colidiu
			Destroy(other.gameObject);
			//Instancia a particula da explosao
			Instantiate(targetExplosion, transform.position, transform.rotation);
			//Soma um ponto ao score
			GameManager.score++;
		}

		if (other.gameObject.tag == "TankGreen") 
		{
			//Instancia a particula da explosao
			Instantiate(tankExplosion, transform.position, transform.rotation);
			//Soma um ponto ao score
			scoreTankRed++;

			//textRedScore.text = "Score : " + scoreTankRed.ToString();
		}


		if (other.gameObject.tag == "TankRed") 
		{
			//Instancia a particula da explosao
			Instantiate(tankExplosion, transform.position, transform.rotation);
			//Soma um ponto ao score
			scoreTankGreen++;

			//textGreenScore.text = "Score : " + scoreTankGreen.ToString();
		}


		//Destroi o gameObject (no caso, o rocket)
		Destroy(gameObject);
	}
}

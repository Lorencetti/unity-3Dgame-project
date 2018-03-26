using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {

	//Define o tempo ate a destruiçao do objeto
	public float timeToDestroy;

	// Use this for initialization
	void Start () {

		//Invoca a funçao DestroyObject no tempo tiemToDestroy
		Invoke ("DestroyObject", timeToDestroy);
	
	}

	//Funçao para destruir o gameObject
	void DestroyObject()
	{
		Destroy (gameObject);
	}
}

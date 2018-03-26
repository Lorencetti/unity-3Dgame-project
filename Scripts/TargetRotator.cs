using UnityEngine;
using System.Collections;

public class TargetRotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		//Rataciona o target nos eixo x(15 graus), y(30 graus) e z(45 graus).
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	
	}
}

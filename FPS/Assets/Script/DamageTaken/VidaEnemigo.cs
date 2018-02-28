using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour {

	public int balas_disparadas = 0;
	public int balas_necesarias = 3;

	void OnTriggerEnter ( Collider other )
	{
		balas_disparadas += 1;
		Destroy (other.gameObject);
		if (balas_necesarias== balas_disparadas){
			Score.scoreValue += 10;
			Destroy(this.gameObject);
		}
	}
}

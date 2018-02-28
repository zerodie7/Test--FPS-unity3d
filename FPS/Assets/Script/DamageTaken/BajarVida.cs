using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarVida : MonoBehaviour {

	public int daño = 10;

	void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var health= hit.GetComponent<VidaPlayer> ();
		if (health != null) {
			health.TakeDamage(daño);
		}
		Destroy (gameObject);
	}



}

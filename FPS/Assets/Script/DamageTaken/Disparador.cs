using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

	public Rigidbody bala;
	public float velocidad = 20;


	void Update () 
	{
		
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody disparoInstantaneo = Instantiate (bala, transform.position, transform.rotation);
			disparoInstantaneo.velocity = transform.TransformDirection (new Vector3 (-100, 0, velocidad));
			Physics.IgnoreCollision(disparoInstantaneo.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
		}

	}
}





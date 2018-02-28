using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloDia : MonoBehaviour {

	//Minutos que pasan
	public float minutosxSegundo;

	private Quaternion startRotation;


	void Start () 
	{
		startRotation = transform.rotation;
	}
	
	void Update () 
	{
		float anguloSol = Time.deltaTime / 360 * minutosxSegundo;
		transform.RotateAround(transform.position, Vector3.forward, anguloSol);	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour {

	private Camera zoom;
	private float defaultFOV;


	void Start () 
	{
		zoom = GetComponent<Camera> ();
		defaultFOV = zoom.fieldOfView;
	}
	
	void Update () 
	{
		if(Input.GetButton("Zoom")){

			zoom.fieldOfView = defaultFOV/1.5f;
		} else{
			zoom.fieldOfView = defaultFOV;
		}


	}
}
